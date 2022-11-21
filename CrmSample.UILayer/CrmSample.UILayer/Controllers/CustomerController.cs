using CrmSample.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CrmSample.UILayer.Controllers
{
    public class CustomerController : Controller
    {
        Context C = new Context();
        public IActionResult Index()
        {
            var values = C.Customers.ToList();
            return View(values);
        }
    }
}
