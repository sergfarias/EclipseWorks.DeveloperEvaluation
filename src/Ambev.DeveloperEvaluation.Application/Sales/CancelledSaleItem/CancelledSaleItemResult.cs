namespace Ambev.DeveloperEvaluation.Application.Sales.CancelledSaleItem;

/// <summary>
/// Represents the response returned after successfully Cancelled a sale item.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the Cancelled sale item,
/// which can be sale item for subsequent operations or reference.
/// </remarks>
public class CancelledSaleItemResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the cancelled sale item.
    /// </summary>
    /// <value>A GUID that uniquely identifies the cancelled sale in the system.</value>
    public Guid Id { get; set; }
}
