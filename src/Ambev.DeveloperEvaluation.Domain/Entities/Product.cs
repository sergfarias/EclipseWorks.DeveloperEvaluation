using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Common.Security;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a product in the system .
/// </summary>
public class Product : BaseEntity, IProduct
{
    /// <summary>
    /// Gets the product's full name.
    /// Must not be null or empty and should contain both first and last names.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; } = 0;

    /// <summary>
    /// Gets the date and time when the product was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets the date and time of the last update to the product's information.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets the unique identifier of the product.
    /// </summary>
    /// <returns>The user's ID as a string.</returns>
    string IProduct.Id => Id.ToString();

    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <returns>The name.</returns>
    string IProduct.Name => Name;

    /// <summary>
    /// Initializes a new instance of the product class.
    /// </summary>
    public Product()
    {
        CreatedAt = DateTime.UtcNow;
    }
}