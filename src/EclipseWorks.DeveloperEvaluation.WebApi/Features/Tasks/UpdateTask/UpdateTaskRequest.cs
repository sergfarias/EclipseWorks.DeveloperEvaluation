namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.UpdateTask;

/// <summary>
/// Represents a request to Update a task in the system.
/// </summary>
public class UpdateTaskRequest
{
    public Guid Id { get; set; }
    
    public Domain.Enums.TaskStatus Status { get; set; }
    public string Details { get; set; } = string.Empty;
}