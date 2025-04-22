using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.Application.Projects.ModifiedProject;

/// <summary>
/// Represents the response returned after successfully modified a sale.
/// </summary>
public class ModifiedProjectResult
{
    /// <summary>
    /// The unique identifier of the created sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The sale number of the sale
    /// </summary>
    public string ProjectNumber { get; set; } = string.Empty;

    /// <summary>
    /// The date of the sale
    /// </summary>
    public DateTime ProjectDate { get; set; }

    /// <summary>
    /// The customer of the sale
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// The current status of the sale
    /// </summary>
    public ProjectStatus Status { get; set; }

    /// <summary>
    /// The itens of the sale
    /// </summary>
    public List<Domain.Entities.Task> Tasks { get; set; } = [];
}
