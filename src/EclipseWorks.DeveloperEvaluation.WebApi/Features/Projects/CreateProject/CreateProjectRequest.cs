using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.CreateProject;

/// <summary>
/// Represents a request to create a new project in the system.
/// </summary>
public class CreateProjectRequest
{
    public string ProjectNumber { get; set; } = string.Empty;

    public DateTime ProjectDate { get; set; }

    public Guid UserId { get; set; }

    public ProjectStatus Status { get; set; }

    public List<Domain.Entities.Task> Tasks { get; set; } = [];

}