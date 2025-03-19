using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Sales.CancelledSale;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledSale;

/// <summary>
/// Profile for mapping between Application and API CancelledSale responses
/// </summary>
public class CancelledSaleProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CancelledSale feature
    /// </summary>
    public CancelledSaleProfile()
    {
        CreateMap<CancelledSaleRequest, CancelledSaleCommand>();
        CreateMap<CancelledSaleResult, CancelledSaleResponse>();
    }
}
