using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.Application.Projects.CreateProject;

/// <summary>
/// Represents the response returned after successfully creating a new project.
/// </summary>
public class CreateProjectResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the newly created project.
    /// </summary>
    /// <value>A GUID that uniquely identifies the created project in the system.</value>
    public Guid Id { get; set; }

    /// <summary>
    /// The number of the project
    /// </summary>
    public string ProjectNumber { get; set; } = string.Empty;

    /// <summary>
    /// The date of the project
    /// </summary>
    public DateTime ProjectDate { get; set; }

    /// <summary>
    /// The user of the prfoject
    /// </summary>
    public Guid UserId { get; set; }

    public ProjectStatus Status { get; set; }

    /// <summary>
    /// The tasks of the project
    /// </summary>
    public List<Domain.Entities.Task> Tasks { get; set; } = [];
}
