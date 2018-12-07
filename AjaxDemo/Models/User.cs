using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxDemo.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
    }
}