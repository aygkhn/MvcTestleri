using FluentValidation;
using NorthwindDemo.Models.Entities;

namespace NorthwindDemo.Models.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(t => t.ProductName).NotEmpty();

            //RuleFor(t => t.CategoryId).GreaterThan(0).WithMessage("Select a category");
            RuleFor(t => t.CategoryId).NotEmpty().WithMessage("Select a category");

            RuleFor(t => t.QuantityPerUnit).NotEmpty().Length(3, 10);

            //RuleFor(t => t.UnitPrice).GreaterThan(5);
            RuleFor(t => t.UnitPrice)
                .InclusiveBetween(5, int.MaxValue)
                .WithMessage("Unit Price must be greater than 5");

            //Client-side validation: http://fluentvalidation.codeplex.com/discussions/256069
        }
    }
}
