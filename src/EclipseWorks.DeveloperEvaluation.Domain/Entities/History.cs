using EclipseWorks.DeveloperEvaluation.Domain.Common;
using EclipseWorks.DeveloperEvaluation.Domain.Enums;
using EclipseWorks.DeveloperEvaluation.Common.Security;
namespace EclipseWorks.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a history in the system.
/// </summary>
public class History : BaseEntity, IHistory
{
    public Guid  TaskId { get; set; }

    public string Details { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public Guid CreatedUserId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    string IHistory.Id => Id.ToString();

    Guid IHistory.TaskId => TaskId;

    string IHistory.Details => Details;
    
    public History()
    {
        CreatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Gets the task current status.
    /// Indicates whether status(Pending, Progress, Completed) of the task in the system.
    /// </summary>
    public HistoryStatus Status { get; set; }

}