using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ModifiedSale;

/// <summary>
/// API response model for ModifiedSale operation
/// </summary>
public class ModifiedSaleResponse
{
    /// <summary>
    /// The unique identifier of the created sale
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
    /// The customer of the sale
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// The Total Sale Amount of the sale
    /// </summary>
    public decimal TotalSaleAmount { get; set; }

    /// <summary>
    /// The Discounts of the sale
    /// </summary>
    public decimal Discounts { get; set; }

    /// <summary>
    /// The branch of the sale
    /// </summary>
    public Guid BranchId { get; set; }

    /// <summary>
    /// The current status of the sale
    /// </summary>
    public SaleStatus Status { get; set; }

    /// <summary>
    /// The itens of the sale
    /// </summary>
    public List<SaleItem> SaleItem { get; set; } = [];
}
