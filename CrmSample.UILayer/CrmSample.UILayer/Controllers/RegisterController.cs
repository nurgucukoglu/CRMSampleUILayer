using CrmSample.EntityLayer.Concrete;
using CrmSample.UILayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CrmSample.UILayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager; //yeni kayıt işlemi için önce usermanager sınıfına gitmek gerekli. sonra usermanager için DI uygulamak gerekli. (class.a Gen Cons)

        public RegisterController(UserManager<AppUser> userManager) //DI
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUser appUser)
        {
            //Async= aynı anda birden fazla işlemi yapmak için kullanılır. Ama bir metot içinde asenkron ifadeleri kullanabilmek için metodu da asenktron ifadeye çevirmek gerekli. So, yukarı async Task ekledim.
            var result = await _userManager.CreateAsync(appUser,appUser.PasswordHash);  //await: bekleme yapmadan çalışmasını sağlar.

            if (result.Succeeded) //eğer esult başarılıysa, create işlemini geçerse:
            {
                return RedirectToAction("Index", "UserList");
            }
            //asenkron metotlarda savae changes yapmıyoruz o kendisi sağlıyormuş.
            return View();
        }


        //MODELLE ÇALIŞMA KISIMLARI (appuser.ı fluent vali.ye bağlamadığımız için hata mesajları almıyorduk.hata mesajları için modelle çalışcaz.
        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index2(UserSignUpModel p) //modelle çalışıcağımız için modeli ekledik ve bir p oluşturduk. Ve sonra atamaları yapmak gerekli:
        {
            if (ModelState.IsValid) //eğer model gereliyse: aşağıdaakileri yap. bunu şu yüzden yazdık. kaytıt olurken index2.de asp-vali-for ve required ve span boş geçmeden kaydetememeyi önleyemedi. Bu Model kontrolünü en başta ayazmak zorundayız.
             //ve buna ele yzmaya gerek yok.sadece index tarafında span asp-vali-for.ları görsek yeterli.
            {
                AppUser appUser = new AppUser() //appuser.ı newledik. ve parametreden gelen değerleri(signupmodel) appuser.a atadık.
                {
                    UserName = p.Username,
                    Name = p.Name,
                    SurName = p.SurName,
                    Email = p.Email,
                    PhoneNumber = p.Phonenumber
                };


                if (p.Password == p.ConfirmPassword) ///eğer şifreler uyumluysa:
                {
                    var result = await _userManager.CreateAsync(appUser, p.Password);  //yeni bir netuser ekleme metodu:createasync //parametresine appuser gönderdik çünkü p.den gelen değerleri appuser.a atadık.(o bağlı db.ye)


                    if (result.Succeeded) //eğer result başarılı olursa
                    {
                        return RedirectToAction("Index", "Login");
                    }

                    else  //validasyonları sağlamıyorsa
                    {
                        foreach (var item in result.Errors) //hata döndürcek. Result.tan gelen hataları okucak burası
                        {
                            ModelState.AddModelError("", item.Description); //(item.Description) hatanın detayını göstericek.
                        }
                    }

                }

                else //şifreler uyuşmuyorsa
                {
                    ModelState.AddModelError("", "şifreler uyuşmuyor");
                }
            }
            return View();
        }
    }
}
