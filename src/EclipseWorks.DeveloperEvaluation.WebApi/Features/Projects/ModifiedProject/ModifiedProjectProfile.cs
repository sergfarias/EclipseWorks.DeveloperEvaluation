using AutoMapper;
using EclipseWorks.DeveloperEvaluation.Application.Projects.ModifiedProject;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.ModifiedProject;

/// <summary>
/// Profile for mapping between Application and API ModifiedProject responses
/// </summary>
public class ModifiedProjectProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ModifiedProject feature
    /// </summary>
    public ModifiedProjectProfile()
    {
        CreateMap<ModifiedProjectRequest, ModifiedProjectCommand>();
        CreateMap<ModifiedProjectResult, ModifiedProjectResponse>();
    }
}
