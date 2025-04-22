using MediatR;

namespace EclipseWorks.DeveloperEvaluation.Application.Projects.DeleteProject;

/// <summary>
/// Command for deleting a project
/// </summary>
public record DeleteProjectCommand : IRequest<DeleteProjectResponse>
{
    /// <summary>
    /// The unique identifier of the project to delete
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Initializes a new instance of DeleteProjectCommand
    /// </summary>
    /// <param name="id">The ID of the project to delete</param>
    public DeleteProjectCommand(Guid id)
    {
        Id = id;
    }
}
