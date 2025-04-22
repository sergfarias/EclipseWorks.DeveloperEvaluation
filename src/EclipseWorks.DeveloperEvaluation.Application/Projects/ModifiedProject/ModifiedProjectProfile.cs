using AutoMapper;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;
using EclipseWorks.DeveloperEvaluation.Application.Projects.ModifiedProject;

namespace EclipseWorks.DeveloperEvaluation.Application.Projects.ModifiedProject;

/// <summary>
/// Profile for mapping between sale entity and ModifiedProjectResponse
/// </summary>
public class ModifiedProjectProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ModifiedProject operation
    /// </summary>
    public ModifiedProjectProfile()
    {
        CreateMap<ModifiedProjectCommand, Project>();
        CreateMap<Project, ModifiedProjectResult>();
    }
}
