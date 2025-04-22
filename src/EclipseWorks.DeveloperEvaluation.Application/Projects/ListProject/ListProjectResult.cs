using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.Application.Projects.ListProject;

/// <summary>
/// Represents the response returned a listing of the project.
/// </summary>
public class ListProjectResult
{
    public Guid Id { get; set; }

    /// <summary>
    /// The project number of the sale
    /// </summary>
    public string ProjectNumber { get; set; } = string.Empty;

    /// <summary>
    /// The date of the project
    /// </summary>
    public DateTime ProjectDate { get; set; }

    /// <summary>
    /// The user of the project
    /// </summary>
    public Guid UserId { get; set; }

    public ProjectStatus Status { get; set; }

    /// <summary>
    /// The tasks of the project
    /// </summary>
    public List<Domain.Entities.Task> Tasks { get; set; } = [];
}
