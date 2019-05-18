using hw1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hw1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PhoneCount = 15,
                UserCount = 20,
                LastAccessDate = DateTime.Now
            };

            return View(homeViewModel);
        }

        public ActionResult FAQ()
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
    }
}