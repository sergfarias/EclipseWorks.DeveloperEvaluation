using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Sales.ModifiedSale;
namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ModifiedSale;

/// <summary>
/// Profile for mapping between Application and API ModifiedSale responses
/// </summary>
public class ModifiedSaleProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ModifiedSale feature
    /// </summary>
    public ModifiedSaleProfile()
    {
        CreateMap<ModifiedSaleRequest, ModifiedSaleCommand>();
        CreateMap<ModifiedSaleResult, ModifiedSaleResponse>();
    }
}
