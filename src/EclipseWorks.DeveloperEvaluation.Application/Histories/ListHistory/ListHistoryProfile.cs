using AutoMapper;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;

namespace EclipseWorks.DeveloperEvaluation.Application.Histories.ListHistory;

/// <summary>
/// Profile for mapping between sale entity and CreateSaleResponse
/// </summary>
public class ListHistoryProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateSale operation
    /// </summary>
    public ListHistoryProfile()
    {
        CreateMap<ListHistoryCommand, History>();
        CreateMap<History, ListHistoryResult>();
    }
}
