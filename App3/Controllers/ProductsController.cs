using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App3.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var categories = new List<SelectListItem> {
                new SelectListItem { Text = "A 1", Value = "P1" },
                new SelectListItem { Text = "A 2", Value = "P10" },
                new SelectListItem { Text = "A 3", Value = "P12" },
                new SelectListItem { Text = "A 4", Value = "P" }
            };

            ViewBag.Categories = categories;
            return View();
        }
    }
}