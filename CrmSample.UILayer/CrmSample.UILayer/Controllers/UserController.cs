using CrmSample.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
//KULLANICILARI LİSTELEYECEĞİZ
namespace CrmSample.UILayer.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager; //alta cons oluşturduk bunu yazdıktan sonra

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager =userManager;
        }

        public IActionResult Index() //listeleme işlemi
        {
            var values = _userManager.Users.ToList();
            return View(values); //modelin içini doldurduk values ile.hata almıştım values yazmayı unutmuşum model null döndü.
        }
    }
}
