using AutoMapper;
using EclipseWorks.DeveloperEvaluation.Application.Projects.ListProject;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.ListProject;

/// <summary>
/// Profile for mapping ListProject feature requests to commands
/// </summary>
public class ListProjectProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ListProject feature
    /// </summary>
    public ListProjectProfile()
    {
        CreateMap<ListProjectResult, ListProjectResponse>();
        CreateMap<ListProjectRequest, ListProjectCommand>();
    }
}
