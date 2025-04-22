using AutoMapper;
using EclipseWorks.DeveloperEvaluation.Application.Tasks.CreateTask;

namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.CreateTask;

/// <summary>
/// Profile for mapping between Application and API CreateTask responses
/// </summary>
public class CreateTaskProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateTask feature
    /// </summary>
    public CreateTaskProfile()
    {
        CreateMap<CreateTaskRequest, CreateTaskCommand>();
        CreateMap<CreateTaskResult, CreateTaskResponse>();
    }
}
