using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledSaleItem;

/// <summary>
/// Represents a request to Cancelled a sale in the system.
/// </summary>
public class CancelledSaleItemRequest
{
    public Guid Id { get; set; }
    
    public SaleStatus Status { get; set; }
}