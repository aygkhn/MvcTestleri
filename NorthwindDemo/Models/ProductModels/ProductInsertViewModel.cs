using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthwindDemo.Models.Entities;

namespace NorthwindDemo.Models.ProductModels
{
    public class ProductInsertViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}