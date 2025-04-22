using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.ModifiedProject;

/// <summary>
/// Represents a request to Modified a project in the system.
/// </summary>
public class ModifiedProjectRequest
{
    public Guid Id { get; set; }

    public string ProjectNumber { get; set; } = string.Empty;

    public DateTime ProjectDate { get; set; }

    public Guid UserId { get; set; }

    public ProjectStatus Status { get; set; }

    public List<Domain.Entities.Task> Tasks { get; set; } = [];
}