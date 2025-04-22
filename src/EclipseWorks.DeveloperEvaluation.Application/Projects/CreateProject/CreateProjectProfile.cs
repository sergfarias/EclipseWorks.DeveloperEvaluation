using AutoMapper;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;

namespace EclipseWorks.DeveloperEvaluation.Application.Projects.CreateProject;

/// <summary>
/// Profile for mapping between sale entity and CreateProjectResponse
/// </summary>
public class ListProjectProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateProject operation
    /// </summary>
    public ListProjectProfile()
    {
        CreateMap<CreateProjectCommand, Project>();
        CreateMap<Project, CreateProjectResult>();
    }
}
