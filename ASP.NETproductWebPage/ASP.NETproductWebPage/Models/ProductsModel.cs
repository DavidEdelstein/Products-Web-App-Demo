using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NETproductWebPage.Models
{
    //GET : Products

    public class ProductsModel
    {
        [Required]
        [MaxLength(20)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Price")]
        public decimal Price { get; set; }

    }
}