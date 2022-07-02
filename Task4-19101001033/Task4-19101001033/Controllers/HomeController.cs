using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task4_19101001033.Models;

namespace Task4_19101001033.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Single_product()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult DBForm()
        {
            return View();
        }

        public IActionResult Test(string first_name, string last_name, string email , 
                                  string phone , string man_option , string wooman_option ,
                                  string sale , string it , string textarea)
        {

            ViewBag.Firstname = first_name;
            ViewBag.Listname = last_name;
            ViewBag.Email = email;
            ViewBag.Phone = phone;
            ViewBag.Option1 = man_option;
            ViewBag.Option2 = wooman_option;
            ViewBag.dropdown1 = sale;
            ViewBag.dropdown2 = it;
            ViewBag.Messege = textarea;

            return View("DBForm");
        }











        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}