using App3.Models;
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
        [HttpGet]
        public ActionResult Index()
        {
            var categories = new List<SelectListItem> {
                new SelectListItem { Text = "A 1", Value = "P1",Disabled=true,Group=new SelectListGroup { Name="B"}},
                new SelectListItem { Text = "A 2", Value = "P10",Selected=true,Group=new SelectListGroup { Name="A"} },
                new SelectListItem { Text = "A 3", Value = "P12",Group=new SelectListGroup { Name="A"} },
                new SelectListItem { Text = "A 4", Value = "P" ,Group=new SelectListGroup { Name="B"}}
            };

            ViewBag.Categories = categories;
            Product product = new Product();
            product.Type = Models.Type.Special;
            return View(product);
        }
        //[ActionName("Home")]
        [HttpPost]
        public ActionResult Index(Product product)
        {
            return null;
        }
        [NonAction]
        public int Sum(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}