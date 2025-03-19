using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Sales.ModifiedSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.ModifiedSale;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

public class ModifiedSaleRequestProfile : Profile
{
    public ModifiedSaleRequestProfile()
    {
        CreateMap<ModifiedSaleRequest, ModifiedSaleCommand>();
    }
}