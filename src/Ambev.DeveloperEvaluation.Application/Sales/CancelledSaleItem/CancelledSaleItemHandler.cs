using MediatR;
using AutoMapper;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Application.Sales.CancelledSaleItem;

/// <summary>
/// Handler for processing CancelledSaleItemCommand requests
/// </summary>
public class CancelledSaleItemHandler : IRequestHandler<CancelledSaleItemCommand, CancelledSaleItemResult>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of CancelledSaleHandler
    /// </summary>
    /// <param name="saleRepository">The sale item repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public CancelledSaleItemHandler(ISaleRepository saleRepository, IMapper mapper)
    {
        _saleRepository = saleRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the CancelledSaleItemCommand request
    /// </summary>
    /// <param name="command">The Cancelledsale Item command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The cancelled sale Item details</returns>
    public async Task<CancelledSaleItemResult> Handle(CancelledSaleItemCommand command, CancellationToken cancellationToken)
    {
        var saleItem = _mapper.Map<SaleItem>(command);

       var saleItemDB = await _saleRepository.SaleItemByIdAsync(saleItem.Id, cancellationToken);
        if (saleItemDB == null)
        {
            throw new ValidationException("Item venda de ID " + saleItem.Id + " não encntrada.");
        }
        else {
            saleItemDB.Status = saleItem.Status; //SaleStatus.Cancelled;
            saleItemDB.UpdatedAt = DateTime.Now;
        }

        var cancelledSaleItem = await _saleRepository.UpdateSaleItemAsync(saleItemDB, cancellationToken);
        var result = _mapper.Map<CancelledSaleItemResult>(cancelledSaleItem);
        return result;
    }
}
