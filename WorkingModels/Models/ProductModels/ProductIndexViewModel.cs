using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingModels.Models.ProductModels
{
    public class ProductIndexViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}