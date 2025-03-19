using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a sale itens in the system.
/// </summary>
public class SaleItem : BaseEntity, ISaleItem
{
    public Guid  SaleId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantities { get; set; } = 0;
    public decimal TotalAmount { get; set; } = 0;
      
    /// <summary>
    /// Gets the date and time when the sale item was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets the date and time of the last update to the item's information.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets the unique identifier of the itens.
    /// </summary>
    /// <returns>The item's ID as a string.</returns>
    string ISaleItem.Id => Id.ToString();

    Guid ISaleItem.SaleId => SaleId;

    Guid ISaleItem.ProductId => ProductId;

    int ISaleItem.Quantities => Quantities;

    decimal ISaleItem.TotalAmount => TotalAmount;

    /// <summary>
    /// Initializes a new instance of the SaleItem class.
    /// </summary>
    public SaleItem()
    {
        CreatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Gets the sale item current status.
    /// Indicates whether the saleitem is cacelled or not cancelled in the system.
    /// </summary>
    public SaleStatus Status { get; set; }
}