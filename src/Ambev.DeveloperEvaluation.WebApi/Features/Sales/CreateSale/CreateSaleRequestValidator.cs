using FluentValidation;
namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Validator for CreateSaleRequest that defines validation rules for sale creation.
/// </summary>
public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - SaleNumber: Required, length between 3 and 20 characters
    /// </remarks>
    public CreateSaleRequestValidator()
    {
          RuleFor(sale => sale.SaleNumber).NotEmpty().Length(3, 20);
    }
}