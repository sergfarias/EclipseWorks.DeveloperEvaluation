using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.ListProject;

/// <summary>
/// API response model for ListProject operation
/// </summary>
public class ListProjectResponse
{
    /// <summary>
    /// The unique identifier of the created project
    /// </summary>
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
    /// The user of the project
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// The current status of the project
    /// </summary>
    public ProjectStatus Status { get; set; }

    /// <summary>
    /// The tasks of the project
    /// </summary>
    public List<Domain.Entities.Task> Tasks { get; set; } = [];
}
