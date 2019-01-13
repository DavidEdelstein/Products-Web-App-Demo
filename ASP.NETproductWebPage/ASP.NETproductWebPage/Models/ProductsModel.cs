using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETproductWebPage.Models
{
    //GET : Products

    public class ProductsModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

    }
}