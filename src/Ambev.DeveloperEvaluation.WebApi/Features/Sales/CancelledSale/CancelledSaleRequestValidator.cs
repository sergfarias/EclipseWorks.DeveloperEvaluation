using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledSale;

/// <summary>
/// Validator for CancelledSaleRequest that defines validation rules for sale creation.
/// </summary>
public class CancelledSaleRequestValidator : AbstractValidator<CancelledSaleRequest>
{
    /// <summary>
    /// Initializes a new instance of the CancelledSaleRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - SaleId: Required
    /// </remarks>
    public CancelledSaleRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Sale ID is required");
    }
}