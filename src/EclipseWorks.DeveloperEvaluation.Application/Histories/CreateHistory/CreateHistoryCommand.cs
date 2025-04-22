using MediatR;
using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.Application.Histories.CreateHistory;

/// <summary>
/// Command for creating a new history.
/// </summary>
public class CreateHistoryCommand : IRequest<CreateHistoryResult>
{
    public Guid TaskId { get; set; }

    public string Details { get; set; } = string.Empty;

    public HistoryStatus Status { get; set; }
}