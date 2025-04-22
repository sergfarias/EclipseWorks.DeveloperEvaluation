using AutoMapper;
using EclipseWorks.DeveloperEvaluation.Application.Tasks.ListTask;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.ListTask;

/// <summary>
/// Profile for mapping ListTask feature requests to commands
/// </summary>
public class ListTaskProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ListTask feature
    /// </summary>
    public ListTaskProfile()
    {
        CreateMap<ListTaskResult, ListTaskResponse>();
        CreateMap<ListTaskRequest, ListTaskCommand>();
    }
}
