using MediatR;
using EclipseWorks.DeveloperEvaluation.Domain.Enums;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;

namespace EclipseWorks.DeveloperEvaluation.Application.Projects.CreateProject;

/// <summary>
/// Command for creating a new project.
/// </summary>
public class CreateProjectCommand : IRequest<CreateProjectResult>
{
    /// <summary>
    /// Gets or sets the number of the project to be created.
    /// </summary>
    public string ProjectNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the date for the project.
    /// </summary>
    public DateTime ProjectDate { get; set; } 

    /// <summary>
    /// Gets or sets the customer for the project.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets the status for the project.
    /// </summary>
    public ProjectStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the itens for the project.
    /// </summary>
    public List<Domain.Entities.Task> Tasks { get; set; } = [];

}