using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = HelloModel.Getstd();
            ViewBag.Name = "Oday Alqarra";
            return View("Index","_layout2",model);
        }
    }
}