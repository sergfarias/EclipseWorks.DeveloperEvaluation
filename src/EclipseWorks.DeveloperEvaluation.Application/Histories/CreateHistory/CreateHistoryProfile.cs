using AutoMapper;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;

namespace EclipseWorks.DeveloperEvaluation.Application.Histories.CreateHistory;

/// <summary>
/// Profile for mapping between history entity and CreateSaleResponse
/// </summary>
public class CreateHistoryProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateHistory operation
    /// </summary>
    public CreateHistoryProfile()
    {
        CreateMap<CreateHistoryCommand, History>();
        CreateMap<History, CreateHistoryResult>();
    }
}
