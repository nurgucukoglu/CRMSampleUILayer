using CrmSample.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CrmSample.UILayer.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager; //login işlemi için signInManager kullandık. //gen const yaptık.

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUser appUser)
        {
            var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.PasswordHash, false, true);
                //PasswordSignInAsync parametreleri: username, password, kişi cookilere kaydolsun mu, kilitleme...bunlar metotdan sonra çıkıyor zaten istediği parametreler diye)
                if(result.Succeeded)
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }
    }
}
