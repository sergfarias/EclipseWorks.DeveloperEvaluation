namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.DeleteProject;

/// <summary>
/// Request model for deleting a project
/// </summary>
public class DeleteProjectRequest
{
    /// <summary>
    /// The unique identifier of the project to delete
    /// </summary>
    public Guid Id { get; set; }
}
