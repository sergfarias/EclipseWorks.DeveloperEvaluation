using AutoMapper;
using EclipseWorks.DeveloperEvaluation.Application.Projects.CreateProject;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.CreateProject;

/// <summary>
/// Profile for mapping between Application and API CreateProject responses
/// </summary>
public class CreateProjectProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateProject feature
    /// </summary>
    public CreateProjectProfile()
    {
        CreateMap<CreateProjectRequest, CreateProjectCommand>();
        CreateMap<CreateProjectResult, GetProjectResponse>();
    }
}
