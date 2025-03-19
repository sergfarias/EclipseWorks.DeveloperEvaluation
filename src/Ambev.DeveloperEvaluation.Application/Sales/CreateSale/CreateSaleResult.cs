using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Represents the response returned after successfully creating a new sale.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the newly created sale,
/// which can be sale for subsequent operations or reference.
/// </remarks>
public class CreateSaleResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the newly created sale.
    /// </summary>
    /// <value>A GUID that uniquely identifies the created sale in the system.</value>
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
