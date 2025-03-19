using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Common.Security;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a customer in the system .
/// </summary>
public class Customer : BaseEntity, ICustomer
{
    /// <summary>
    /// Gets the customer's full name.
    /// Must not be null or empty and should contain both first and last names.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets the date and time when the customer was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets the date and time of the last update to the customer's information.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets the unique identifier of the customer.
    /// </summary>
    /// <returns>The customer's ID as a string.</returns>
    string ICustomer.Id => Id.ToString();

    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <returns>The ame.</returns>
    string ICustomer.Name => Name;

    /// <summary>
    /// Initializes a new instance of the Customer class.
    /// </summary>
    public Customer()
    {
        CreatedAt = DateTime.UtcNow;
    }
}