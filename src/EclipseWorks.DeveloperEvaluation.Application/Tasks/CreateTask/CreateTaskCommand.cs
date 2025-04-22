using MediatR;
using EclipseWorks.DeveloperEvaluation.Domain.Enums;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;

namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.CreateTask;

/// <summary>
/// Command for creating a new sale.
/// </summary>
public class CreateTaskCommand : IRequest<CreateTaskResult>
{
    public Guid ProjectId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Details { get; set; } = string.Empty;

    public DateTime DueDate { get; set; }

    public Priority Priority { get; set; }
}