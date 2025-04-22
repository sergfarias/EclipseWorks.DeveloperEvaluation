using AutoMapper;

namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.ListTask;

/// <summary>
/// Profile for mapping between task entity and CreateTaskResponse
/// </summary>
public class ListTaskProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateTask operation
    /// </summary>
    public ListTaskProfile()
    {
        CreateMap<ListTaskCommand, Domain.Entities.Task>();
        CreateMap<Domain.Entities.Task, ListTaskResult>();
    }
}
