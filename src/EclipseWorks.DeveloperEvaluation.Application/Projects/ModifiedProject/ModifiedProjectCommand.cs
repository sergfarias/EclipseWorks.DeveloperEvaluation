using MediatR;
using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.Application.Projects.ModifiedProject;

/// <summary>
/// Command for modified a project.
/// </summary>
public class ModifiedProjectCommand : IRequest<ModifiedProjectResult>
{
    /// <summary>
    /// Gets or sets the sale for the sale.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the number of the sale to be created.
    /// </summary>
    public string ProjectNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the date for the sale.
    /// </summary>
    public DateTime ProjectDate { get; set; } 

    /// <summary>
    /// Gets or sets the customer for the sale.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets the status for the sale.
    /// </summary>
    public ProjectStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the itens for the sale.
    /// </summary>
    public List<Domain.Entities.Task> Tasks { get; set; } = [];

}