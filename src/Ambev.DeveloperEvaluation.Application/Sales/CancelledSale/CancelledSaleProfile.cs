using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.CancelledSale;

/// <summary>
/// Profile for mapping between sale entity and CancelledSaleResponse
/// </summary>
public class CancelledSaleProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CancelledSale operation
    /// </summary>
    public CancelledSaleProfile()
    {
        CreateMap<CancelledSaleCommand, Sale>();
        CreateMap<Sale, CancelledSaleResult>();
    }
}
