using AutoMapper;
namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.UpdateTask;

/// <summary>
/// Profile for mapping between task entity and CancelledTaskResponse
/// </summary>
public class UpdateTaskProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CancelledTask operation
    /// </summary>
    public UpdateTaskProfile()
    {
        CreateMap<UpdateTaskCommand, Domain.Entities.Task>();
        CreateMap<Domain.Entities.Task, UpdateTaskResult>();
    }
}
