using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArabiaMvc;

namespace DemoMvc.Controllers
{
    public class HomeController : ArabiaController
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

        public JsonResult TestJson()
        {
            var sampleData = new {Byte = (byte)44, Short = (short)-22222, UShort = (ushort)22222, Int = 2144222, Long = 22222222222, Double = 2.5D, Float = 2.2F, Decimal = (decimal) 22222222222.2, Date = DateTime.Now};

            return Json(sampleData, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ArabiaExtensions()
        {
            return View();
        }

        public ActionResult ArabiaMvc()
        {
            return View();
        }
    }
}