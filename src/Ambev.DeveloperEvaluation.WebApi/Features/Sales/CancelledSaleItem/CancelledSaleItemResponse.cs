using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledItemSale;

/// <summary>
/// API response model for CancelledSale operation
/// </summary>
public class CancelledSaleItemResponse
{
    /// <summary>
    /// The unique identifier of the Cancelled sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The sale id of the sale
    /// </summary>
    public string SaleId { get; set; } = string.Empty;

    /// <summary>
    /// The current status of the sale
    /// </summary>
    public SaleStatus Status { get; set; }

}
