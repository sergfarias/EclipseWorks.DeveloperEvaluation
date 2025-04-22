using AutoMapper;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.DeleteProject;

/// <summary>
/// Profile for mapping DeleteProject feature requests to commands
/// </summary>
public class DeleteProjectProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for DeleteProject feature
    /// </summary>
    public DeleteProjectProfile()
    {
        CreateMap<Guid, Application.Projects.DeleteProject.DeleteProjectCommand>()
            .ConstructUsing(id => new Application.Projects.DeleteProject.DeleteProjectCommand(id));
    }
}
