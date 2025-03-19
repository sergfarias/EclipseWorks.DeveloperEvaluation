using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Sales.CancelledSaleItem;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledSaleItem;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

public class CancelledSaleItemRequestProfile : Profile
{
    public CancelledSaleItemRequestProfile()
    {
        CreateMap<CancelledSaleItemRequest, CancelledSaleItemCommand>();
    }
}