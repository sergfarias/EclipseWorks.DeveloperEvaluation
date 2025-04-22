using MediatR;
using EclipseWorks.DeveloperEvaluation.Domain.Enums;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;

namespace EclipseWorks.DeveloperEvaluation.Application.Histories.ListHistory;

/// <summary>
/// Command for list a history.
/// </summary>
public class ListHistoryCommand : IRequest<List<ListHistoryResult>>
{
    /// <summary>
    /// Gets or sets the project for the project.
    /// </summary>
    public Guid IdTask { get; set; }

}