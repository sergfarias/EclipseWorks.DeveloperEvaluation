using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledSale;

/// <summary>
/// API response model for CancelledSale operation
/// </summary>
public class CancelledSaleResponse
{
    /// <summary>
    /// The unique identifier of the Cancelled sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The sale number of the sale
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// The date of the sale
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// The current status of the sale
    /// </summary>
    public SaleStatus Status { get; set; }

}
