using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RPNCalculator;

namespace DashBoard.Controllers
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

        public ActionResult RPN()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RPN(FormCollection coll)
        {
            RPNCal obj = new RPNCal();
            string inputVal = coll["rpnInput"];
            int? result = obj.GetRPN(inputVal);
            ViewBag.Message = result;

            return View();
        }
    }
}