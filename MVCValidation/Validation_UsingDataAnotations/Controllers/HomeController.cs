using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation_UsingDataAnotations.Models;

namespace Validation_UsingDataAnotations.Controllers
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
        [HttpGet]
        
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryTokenAttribute]
        public ActionResult Create(User obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.Gender=="Male")
                {
                    ViewBag.Message = "Success";
                    return View("Index");
                }
                else {
                    ViewBag.Message = "Warning";
                    return View("Index");
                }
            }
            return View("Index");
        }
    }
}