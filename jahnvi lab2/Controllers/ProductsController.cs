using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jahnvi_lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        //GET : Products/Item
        public ActionResult Item(String ItemName)

        {
            ViewBag.ItemName = ItemName;
            return View();
        }
    }
}