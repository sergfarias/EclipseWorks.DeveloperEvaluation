namespace Ambev.DeveloperEvaluation.Application.Sales.CancelledSale;

/// <summary>
/// Represents the response returned after successfully Cancelled a sale.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the Cancelled sale,
/// which can be sale for subsequent operations or reference.
/// </remarks>
public class CancelledSaleResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the cancelled sale.
    /// </summary>
    /// <value>A GUID that uniquely identifies the cancelled sale in the system.</value>
    public Guid Id { get; set; }
}
