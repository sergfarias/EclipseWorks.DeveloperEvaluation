using EclipseWorks.DeveloperEvaluation.Application.Histories.CreateHistory;
using AutoMapper;

namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Histories.CreateHistory;

/// <summary>
/// Profile for mapping between Application and API CreateHistory responses
/// </summary>
public class CreateHistoryProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateHistory feature
    /// </summary>
    public CreateHistoryProfile()
    {
        CreateMap<CreateHistoryRequest, CreateHistoryCommand>();
        CreateMap<CreateHistoryResult, CreateHistoryResponse>();
    }
}
