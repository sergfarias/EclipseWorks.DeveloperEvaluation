using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Sales.CancelledSaleItem;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledItemSale;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledSaleItem;

/// <summary>
/// Profile for mapping between Application and API CancelledSale responses
/// </summary>
public class CancelledSaleItemProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CancelledSale feature
    /// </summary>
    public CancelledSaleItemProfile()
    {
        CreateMap<CancelledSaleItemRequest, CancelledSaleItemCommand>();
        CreateMap<CancelledSaleItemResult, CancelledSaleItemResponse>();
    }
}
