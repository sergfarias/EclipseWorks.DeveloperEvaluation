using AutoMapper;
using EclipseWorks.DeveloperEvaluation.Application.Histories.ListHistory;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Histories.ListHistory;

/// <summary>
/// Profile for mapping ListHistory feature requests to commands
/// </summary>
public class ListHistoryProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ListHistory feature
    /// </summary>
    public ListHistoryProfile()
    {
        CreateMap<ListHistoryResult, ListHistoryResponse>();
        CreateMap<ListHistoryRequest, ListHistoryCommand>();
    }
}
