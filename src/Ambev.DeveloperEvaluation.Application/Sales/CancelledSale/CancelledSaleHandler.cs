using MediatR;
using AutoMapper;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Application.Sales.CancelledSale;

/// <summary>
/// Handler for processing CancelledSaleCommand requests
/// </summary>
public class CancelledSaleHandler : IRequestHandler<CancelledSaleCommand, CancelledSaleResult>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of CancelledSaleHandler
    /// </summary>
    /// <param name="saleRepository">The sale repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public CancelledSaleHandler(ISaleRepository  saleRepository, IMapper mapper)
    {
        _saleRepository = saleRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the CancelledSaleCommand request
    /// </summary>
    /// <param name="command">The Cancelledsale command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The cancelled sale details</returns>
    public async Task<CancelledSaleResult> Handle(CancelledSaleCommand command, CancellationToken cancellationToken)
    {
        var sale = _mapper.Map<Sale>(command);

       var saleDB = await _saleRepository.GetByIdAsync(sale.Id, cancellationToken);
        if (saleDB == null)
        {
            throw new ValidationException("Venda de ID " + sale.Id + " não encntrada.");
        }
        else {
            saleDB.Status = sale.Status; //SaleStatus.Cancelled;
            saleDB.UpdatedAt = DateTime.Now;
        }

        var cancelledSale = await _saleRepository.UpdateAsync(saleDB, cancellationToken);
        var result = _mapper.Map<CancelledSaleResult>(cancelledSale);
        return result;
    }
}
