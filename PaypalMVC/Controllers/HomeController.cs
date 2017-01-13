using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaypalMVC.Models;

namespace PaypalMVC.Controllers
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
        
        //public ActionResult ValidateCommand(string product, string totalPrice)
        //{
        //    bool useSandbox = Convert.ToBoolean(ConfigurationManager.AppSettings["IsSandbox"]);
        //    var paypal = new PayPalModel(useSandbox);

        //    paypal.item_name = product;
        //    paypal.amount = totalPrice;
        //    return View(paypal);
        //}
    }
}
