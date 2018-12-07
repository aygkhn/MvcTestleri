using System;

namespace SecurityDemo.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string About { get; set; }
    }
}