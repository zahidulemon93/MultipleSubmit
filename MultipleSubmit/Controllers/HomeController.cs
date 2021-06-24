using MultipleSubmit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultipleSubmit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //1. Multiple buttons with different names

        public ActionResult IndexTecnique1()
        {
            return View();
        }

        // 2. Multiple buttons with the same name
        public ActionResult IndexTecnique2()
        {
            return View();
        }

        //3. HTML5 formaction and formmethod attributes

        public ActionResult IndexTecnique3()
        {
            return View();
        }


        //4. jQuery / JavaScript code
        public ActionResult IndexTecnique4()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessFormTechnique1(Customer obj,
                   string save, string cancel)
        {
            if (!string.IsNullOrEmpty(save))
            {
                ViewBag.Message = "Customer saved successfully!";
            }
            if (!string.IsNullOrEmpty(cancel))
            {
                ViewBag.Message = "The operation was cancelled!";
            }
            return View("Result", obj);
        }


        [HttpPost]
        public ActionResult ProcessFormTechnique2(Customer obj, string submit)
        {
            switch (submit)
            {
                case "Save":
                    ViewBag.Message = "Customer saved successfully!";
                    break;
                case "Cancel":
                    ViewBag.Message = "The operation was cancelled!";
                    break;
            }
            return View("Result", obj);
        }

        [HttpPost]
        public ActionResult SaveForm(Customer obj)
        {
            ViewBag.Message = "Customer saved successfully!";
            return View("Result", obj);
        }

        [HttpPost]
        public ActionResult CancelForm(Customer obj)
        {
            ViewBag.Message = "The operation was cancelled!";
            return View("Result", obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostData(string submitButton1, string submitButton2,
                                     string givenName, string surname)
        {
            var button = submitButton1 ?? submitButton2;
            return Content("You submitted the form by " + button);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostDataNormal(string givenName, string surname)
        {
            return Content("You submitted the form.");
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
    }
}