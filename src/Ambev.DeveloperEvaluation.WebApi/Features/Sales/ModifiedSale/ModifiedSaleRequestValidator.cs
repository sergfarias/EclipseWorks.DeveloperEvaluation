using FluentValidation;
namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ModifiedSale;

/// <summary>
/// Validator for ModifiedSaleRequest that defines validation rules for sale Modified.
/// </summary>
public class ModifiedSaleRequestValidator : AbstractValidator<ModifiedSaleRequest>
{
    /// <summary>
    /// Initializes a new instance of the ModifiedSaleRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - SaleNumber: Required, length between 3 and 20 characters
    /// </remarks>
    public ModifiedSaleRequestValidator()
    {
        RuleFor(x => x.Id)
           .NotEmpty()
           .WithMessage("Sale ID is required");

        RuleFor(sale => sale.SaleNumber).NotEmpty().Length(3, 20);
    }
}