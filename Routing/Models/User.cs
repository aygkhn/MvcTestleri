using System;
using System.ComponentModel.DataAnnotations;

namespace Routing.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
