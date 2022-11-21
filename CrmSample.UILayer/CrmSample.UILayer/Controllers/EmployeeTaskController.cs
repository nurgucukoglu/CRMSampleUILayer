using CrmSample.BusinessLayer.Abstract;
using CrmSample.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using System.Linq;

namespace CrmSample.UILayer.Controllers
{
    public class EmployeeTaskController : Controller
    {
        private readonly IEmployeeTaskService _employeeTaskService;
        private readonly UserManager<AppUser> _userManager; //user tablosuyla çalışıcağımız içiçn ekledik. personel seçerken(olan const.içine bunu eklemek için _userManager ctrl. add parameter to..)

        public EmployeeTaskController(IEmployeeTaskService employeeTaskService, UserManager<AppUser> userManager)
        {
            _employeeTaskService = employeeTaskService;
            _userManager = userManager;
        }

        public IActionResult Index() //önce kendi metodumuzla verileri görüntülücez.
        {
            var values = _employeeTaskService.TGetEmployeeTaskByEmployee();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            //DROPDOWN İÇİNDE PERSONEL SEÇİCEZ:
            List<SelectListItem> userValues = (from x in _userManager.Users.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name + " " + x.SurName,
                                                   Value = x.Id.ToString()
                                               }).ToList();
            ViewBag.v = userValues;
            return View();
        }


        [HttpPost]
        public IActionResult AddTask(EmployeeTask employeeTask)
        {
            employeeTask.Status = "Görev Atandı"; //görevin başlangıçtaki statüsü
            employeeTask.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //görev atandığı zaman default olarak tarih gelicek o anın 
            //statusu ve dadtei gönderddik.diğerleri inputlar içinde geliyor olacak.
            _employeeTaskService.TInsert(employeeTask);
            return RedirectToAction("Index");
        }
    }
}
