using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.CancelledSaleItem;

/// <summary>
/// Profile for mapping between sale entity and CancelledSaleItemResponse
/// </summary>
public class CancelledSaleItemProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CancelledSaleItem operation
    /// </summary>
    public CancelledSaleItemProfile()
    {
        CreateMap<CancelledSaleItemCommand, SaleItem>();
        CreateMap<SaleItem, CancelledSaleItemResult>();
    }
}
