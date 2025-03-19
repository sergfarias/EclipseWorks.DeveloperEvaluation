using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.ModifiedSale;

/// <summary>
/// Profile for mapping between sale entity and ModifiedSaleResponse
/// </summary>
public class ModifiedSaleProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ModifiedSale operation
    /// </summary>
    public ModifiedSaleProfile()
    {
        CreateMap<ModifiedSaleCommand, Sale>();
        CreateMap<Sale, ModifiedSaleResult>();
    }
}
