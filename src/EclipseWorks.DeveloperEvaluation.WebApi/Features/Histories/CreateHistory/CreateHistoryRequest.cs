using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Histories.CreateHistory;

/// <summary>
/// Represents a request to create a new history in the system.
/// </summary>
public class CreateHistoryRequest
{
    public Guid TaskId { get; set; }

    public string Details { get; set; } = string.Empty;
    
    public HistoryStatus Status { get; set; }
}