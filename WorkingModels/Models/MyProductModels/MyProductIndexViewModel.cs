using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingModels.Models.MyProductModels
{
    public class MyProductIndexViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}