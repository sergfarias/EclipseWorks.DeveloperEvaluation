using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledSale;

/// <summary>
/// Represents a request to Cancelled a sale in the system.
/// </summary>
public class CancelledSaleRequest
{
    public Guid Id { get; set; }
    
    public SaleStatus Status { get; set; }
}