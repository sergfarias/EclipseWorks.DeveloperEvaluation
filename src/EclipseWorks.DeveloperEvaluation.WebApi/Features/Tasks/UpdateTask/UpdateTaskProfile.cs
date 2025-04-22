using AutoMapper;
using EclipseWorks.DeveloperEvaluation.Application.Tasks.UpdateTask;

namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.UpdateTask;

/// <summary>
/// Profile for mapping between Application and API UpdateTask responses
/// </summary>
public class UpdateTaskProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for UpdateTask feature
    /// </summary>
    public UpdateTaskProfile()
    {
        CreateMap<UpdateTaskRequest, UpdateTaskCommand>();
        CreateMap<UpdateTaskResult, UpdateTaskResponse>();
    }
}
