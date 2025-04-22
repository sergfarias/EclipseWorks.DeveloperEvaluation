namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.ListTask;

/// <summary>
/// Represents a request to list of the task by idTask in the system.
/// </summary>
public class ListTaskRequest
{
    public Guid IdProject { get; set; }
    
}