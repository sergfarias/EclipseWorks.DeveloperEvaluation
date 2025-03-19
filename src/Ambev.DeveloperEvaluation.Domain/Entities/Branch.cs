using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Common.Security;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a branch in the system.
/// </summary>
public class Branch : BaseEntity, IBranch
{
    /// <summary>
    /// Gets the branch's full name.
    /// Must not be null or empty and should contain both first and last names.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets the date and time when the branch was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets the date and time of the last update to the branch's information.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets the unique identifier of the branch.
    /// </summary>
    /// <returns>The branch's ID as a string.</returns>
    string IBranch.Id => Id.ToString();

    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <returns>The name.</returns>
    string IBranch.Name => Name;

    /// <summary>
    /// Initializes a new instance of the Branch class.
    /// </summary>
    public Branch()
    {
        CreatedAt = DateTime.UtcNow;
    }
}