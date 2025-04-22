using EclipseWorks.DeveloperEvaluation.Domain.Entities;
using EclipseWorks.DeveloperEvaluation.Domain.Enums;

namespace EclipseWorks.DeveloperEvaluation.Application.Histories.ListHistory;

/// <summary>
/// Represents the response returned after successfully creating a new sale.
/// </summary>
public class ListHistoryResult
{
    public Guid Id { get; set; }

    public Guid TaskId { get; set; }

    public string Details { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public HistoryStatus Status { get; set; }

}

