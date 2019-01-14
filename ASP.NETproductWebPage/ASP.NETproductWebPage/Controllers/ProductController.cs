using ASP.NETproductWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETproductWebPage.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult AddProduct()
        {
            return View();
        }

        public ActionResult ListProducts(ProductsModel model)
        {
            List<ProductsModel> product = new List<ProductsModel>();

            product.Add(new ProductsModel { Name = "Apple", Description = "Grows on a tree.", Price = 10 });
            product.Add(new ProductsModel { Name = "Banana", Description = "Do I eat the yellow part?", Price = 2 });
            product.Add(new ProductsModel { Name = "Orange", Description = "Nature's candy.", Price = 2.75m });
            product.Add(new ProductsModel { Name = "Kiwi", Description = "The fuzzy skin is really not that bad.", Price = 3.05m });

            return View(product);
        }

        [HttpPost]
        public ActionResult Add(ProductsModel model)
        {
            if (ModelState.IsValid)
            {
                // Maybe save this?
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            return View("AddProduct", model);
        }
    }
}