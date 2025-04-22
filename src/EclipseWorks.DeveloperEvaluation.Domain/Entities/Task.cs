using EclipseWorks.DeveloperEvaluation.Domain.Common;
using EclipseWorks.DeveloperEvaluation.Common.Security;
using EclipseWorks.DeveloperEvaluation.Domain.Enums;
using TaskStatus = EclipseWorks.DeveloperEvaluation.Domain.Enums.TaskStatus;

namespace EclipseWorks.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a sale itens in the system.
/// </summary>
public class Task : BaseEntity, ITask
{
    public Guid  ProjectId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Details { get; set; } = string.Empty;

    public DateTime DueDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public List<History>? Histories { get; set; }


    string ITask.Id => Id.ToString();

    Guid ITask.ProjectId => ProjectId;

    string ITask.Title => Title;

    string ITask.Description => Description;

    string ITask.Details => Details;
    
    DateTime ITask.DueDate => DueDate;

    public Task()
    {
        CreatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Gets the task current status.
    /// Indicates whether status(Pending, Progress, Completed) of the task in the system.
    /// </summary>
    public TaskStatus Status { get; set; }

    /// <summary>
    /// Gets the task current priority.
    /// Indicates whether priority(Low, Average, High) of the task in the system.
    /// </summary>
    public Priority Priority { get; set; }

}