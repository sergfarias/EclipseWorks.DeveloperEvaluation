using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledSaleItem;

/// <summary>
/// Validator for CancelledSaleRequest that defines validation rules for sale creation.
/// </summary>
public class CancelledSaleItemRequestValidator : AbstractValidator<CancelledSaleItemRequest>
{
    /// <summary>
    /// Initializes a new instance of the CancelledSaleRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - SaleId: Required
    /// </remarks>
    public CancelledSaleItemRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("SaleItem ID is required");
    }
}