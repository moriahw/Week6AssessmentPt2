using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week6Assessment2.Models;

namespace Week6Assessment2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            northwindEntities OrderInfo = new northwindEntities();
            List<Order> OrderData = OrderInfo.Orders.ToList();

            ViewBag.OList = OrderData;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Nothing to see!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You're still here?";

            return View();
        }
    }
}