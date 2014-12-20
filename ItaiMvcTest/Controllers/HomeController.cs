using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ItaiMvcTest.Models;

namespace ItaiMvcTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DoMath(String number)
        {
            ViewBag.Message = "Your contact page.";

            DoMathViewModel model = new DoMathViewModel();

            model.NumberEntered = Convert.ToDecimal( number );


            decimal numberEntered = model.NumberEntered;
            decimal percent = 0.1M;

            //find what are 10 percent out of the number
            decimal tenPercentOfNumber = numberEntered * percent; //https://answers.yahoo.com/question/index?qid=20090927045405AA2ef1E

            model.TenPercentMore = numberEntered + tenPercentOfNumber;
            model.TenPercentLess = numberEntered - tenPercentOfNumber;


            return View(model);

        }

    }

}
