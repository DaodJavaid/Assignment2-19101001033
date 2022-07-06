using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task4_19101001033.Models;

namespace Task4_19101001033.Controllers
{
    public class HomeController : Controller
    {
        /* private readonly ILogger<HomeController> _logger;*/

        private readonly SignupDbContext _signupDbContext;


        public HomeController(SignupDbContext signupDbContext)
        {
            _signupDbContext = signupDbContext;
        }


       /* public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

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
        
        public IActionResult Account()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }


        /* public IActionResult DBForm()
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

         */

        [HttpPost]
        /* Register User*/
        public IActionResult Signup( Signup signup )
        {
            /*_signupDbContext.Signup.Add(signup);
            _signupDbContext.Signup.SaveChanges();
*/
            return View("Index");
        }

        public IActionResult Login(string email, string password)
        {
            if(email == "Daod" && password == "123")
            {
                return View("Contact");
            }
            else
            {
                return View("Shop");
            }
        }



        public IActionResult Single_Product_count(string pname, string price, string count)
        {
            int total_price = int.Parse(price) * int.Parse(count);
            
            ViewBag.Product_name = pname;
            ViewBag.Product_price = total_price;

            return View("Checkout");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new AccountViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}