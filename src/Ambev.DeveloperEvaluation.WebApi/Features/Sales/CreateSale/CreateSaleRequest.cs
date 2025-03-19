using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Represents a request to create a new sale in the system.
/// </summary>
public class CreateSaleRequest
{
    public string SaleNumber { get; set; } = string.Empty;

    public DateTime SaleDate { get; set; }

    public Guid CustomerId { get; set; }

    public decimal TotalSaleAmount { get; set; }

    public decimal Discounts { get; set; }

    public Guid BranchId { get; set; }
    public SaleStatus Status { get; set; }

    public List<SaleItem> SaleItem { get; set; } = [];

}