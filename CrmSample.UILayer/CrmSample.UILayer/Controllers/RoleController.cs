using CrmSample.EntityLayer.Concrete;
using CrmSample.UILayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CrmSample.UILayer.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }
        //DEP INJ UYGULADIK YUKARDA

        public IActionResult Index() //ROLLERİ LİSTELEME
        {
            var values= _roleManager.Roles.ToList(); //role manager.da direkt tolist gelmedi. roles.tolist yaptık.
            return View(values);
        }


        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel model) //rol tablosuna eklemek istediğimiz propertyleri tutacak metodun içi(RoleViewModel) model yerine p de yazılabilirdi.
        {
            if (ModelState.IsValid) //eğer model geçerliyse
            {
                AppRole appRole = new AppRole() //rol sınıfı içindeki propertylere erişip atama yapıcaz:
                {
                    Name = model.RoleName //roleviewe.deki role namei approle.e atadık
                };
                var result = await _roleManager.CreateAsync(appRole);

                if (result.Succeeded) 
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> DeleteRole(int id) //identity.de silme işlemi
        {
            var role = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            var result=await _roleManager.DeleteAsync(role);
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
