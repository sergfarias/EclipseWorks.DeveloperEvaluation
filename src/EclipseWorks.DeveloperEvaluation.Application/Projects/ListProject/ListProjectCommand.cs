using MediatR;
namespace EclipseWorks.DeveloperEvaluation.Application.Projects.ListProject;

/// <summary>
/// Command for list a project.
/// </summary>
public class ListProjectCommand : IRequest<List<ListProjectResult>>
{
    public Guid IdUser { get; set; }

}