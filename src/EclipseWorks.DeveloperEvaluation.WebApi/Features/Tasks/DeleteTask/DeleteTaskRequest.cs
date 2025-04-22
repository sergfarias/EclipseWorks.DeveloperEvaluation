namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.DeleteTask;

/// <summary>
/// Request model for deleting a task
/// </summary>
public class DeleteTaskRequest
{
    /// <summary>
    /// The unique identifier of the task to delete
    /// </summary>
    public Guid Id { get; set; }
}
