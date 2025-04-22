using EclipseWorks.DeveloperEvaluation.Domain.Entities;
using EclipseWorks.DeveloperEvaluation.Domain.Enums;

namespace EclipseWorks.DeveloperEvaluation.Application.Histories.CreateHistory;

/// <summary>
/// Represents the response returned after successfully creating a new history.
/// </summary>
public class CreateHistoryResult
{
      public Guid Id { get; set; }

    public Guid TaskId { get; set; }

    public string Details { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public HistoryStatus Status { get; set; }

}
