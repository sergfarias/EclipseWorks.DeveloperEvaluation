using AutoMapper;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.DeleteTask;

/// <summary>
/// Profile for mapping DeleteTask feature requests to commands
/// </summary>
public class DeleteTaskProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for DeleteTask feature
    /// </summary>
    public DeleteTaskProfile()
    {
        CreateMap<Guid, Application.Tasks.DeleteTask.DeleteTaskCommand>()
            .ConstructUsing(id => new Application.Tasks.DeleteTask.DeleteTaskCommand(id));
    }
}
