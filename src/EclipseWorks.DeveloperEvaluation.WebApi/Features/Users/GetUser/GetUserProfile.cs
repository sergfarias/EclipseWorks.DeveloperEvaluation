using AutoMapper;

namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Users.GetUser;

/// <summary>
/// Profile for mapping GetUser feature requests to commands
/// </summary>
public class GetProjectProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetUser feature
    /// </summary>
    public GetProjectProfile()
    {
        CreateMap<Guid, Application.Users.GetUser.GetUserCommand>()
            .ConstructUsing(id => new Application.Users.GetUser.GetUserCommand(id));
    }
}
