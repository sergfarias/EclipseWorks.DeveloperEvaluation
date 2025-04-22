using AutoMapper;
namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.CreateTask;

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
        CreateMap<CreateTaskCommand, Domain.Entities.Task>();
        CreateMap<Domain.Entities.Task, CreateTaskResult>();
    }
}
