using AutoMapper;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;

namespace EclipseWorks.DeveloperEvaluation.Application.Projects.ListProject;

public class ListProjectProfile : Profile
{
    public ListProjectProfile()
    {
        CreateMap<ListProjectCommand, Project>();
        CreateMap<Project, ListProjectResult>();
    }
}
