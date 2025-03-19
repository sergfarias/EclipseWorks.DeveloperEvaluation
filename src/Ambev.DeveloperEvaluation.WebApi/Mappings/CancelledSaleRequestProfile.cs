using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Sales.CancelledSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CancelledSale;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

public class CancelledSaleRequestProfile : Profile
{
    public CancelledSaleRequestProfile()
    {
        CreateMap<CancelledSaleRequest, CancelledSaleCommand>();
    }
}