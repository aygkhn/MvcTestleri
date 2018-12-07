using System.ComponentModel.DataAnnotations;
using NorthwindDemo.Models.ValidationRules.FluentValidation;

namespace NorthwindDemo.Models.Entities
{
    [FluentValidation.Attributes.Validator(typeof(ProductValidator))]
    public class Product
    {
        public int ProductId { get; set; }

        //[Required]
        public string ProductName { get; set; }

        //[Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }

        //[StringLength(5)]
        public string QuantityPerUnit { get; set; }

        //[Range(0, 100)]
        public decimal UnitPrice { get; set; }

        public short UnitsInStock { get; set; }  
      
        public Category Category { get; set; }
    }
}
