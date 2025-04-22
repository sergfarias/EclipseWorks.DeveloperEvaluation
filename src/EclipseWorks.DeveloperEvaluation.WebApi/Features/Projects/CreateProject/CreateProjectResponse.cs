using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.CreateProject;

/// <summary>
/// API response model for CreateProject operation
/// </summary>
public class GetProjectResponse
{
    /// <summary>
    /// The unique identifier of the created project
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The number of the roject
    /// </summary>
    public string ProjectNumber { get; set; } = string.Empty;

    /// <summary>
    /// The date of the Project
    /// </summary>
    public DateTime ProjectDate { get; set; }

    /// <summary>
    /// The user owner of the Project
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// The current status of the Project
    /// </summary>
    public ProjectStatus Status { get; set; }

    /// <summary>
    /// The tasks of the Project
    /// </summary>
    public List<Domain.Entities.Task> Tasks { get; set; } = [];
}
