using Jquery_Tst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;


namespace Jquery_Tst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult getstudent()
        {
            Student std = new Student()
            {
                id = 1,
                Name = "heelo",
                age = 34

            };
            var json=JsonConvert.SerializeObject(std);  
            return Json(json,JsonRequestBehavior.AllowGet);
        }
    }
}