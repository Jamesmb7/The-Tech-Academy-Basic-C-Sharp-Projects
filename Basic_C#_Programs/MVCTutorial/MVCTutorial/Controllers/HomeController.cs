using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"E:\Tech_Academy\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\MVCTutorial\log.txt", text);
            //Random rnd = new Random(10);
            //var num = rnd.Next();

            ////ViewBag.RandomNumber = num;
            //if (num > 20000)
            //{
            //    return View("About");
            //}
            return View(); //This is the same as return View("Index")
            //return Content("Hello"); //Will return a hello for contact tab.
            //return RedirectToAction("Contact"); //Sends you to Contact immediately, different from return view contact (return view doesn't change the url). 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid Page");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}