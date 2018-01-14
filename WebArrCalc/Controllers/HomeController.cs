using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebArrCalc.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.CalcControllerClient cl = new ServiceReference1.CalcControllerClient();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Sum(string arr)
        {
            return Json(cl.Sum(arr), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Mul(string arr)
        {
            return Json(cl.Mul(arr), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Mean(string arr)
        {
            return Json(cl.Mean(arr), JsonRequestBehavior.AllowGet);
        }
    }
}