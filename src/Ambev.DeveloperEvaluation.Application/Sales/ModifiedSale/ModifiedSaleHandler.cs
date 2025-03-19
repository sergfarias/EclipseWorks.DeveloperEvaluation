using MediatR;
using AutoMapper;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Services.Calcule;

namespace Ambev.DeveloperEvaluation.Application.Sales.ModifiedSale;

/// <summary>
/// Handler for processing ModifiedSaleCommand requests
/// </summary>
public class ModifiedSaleHandler : IRequestHandler<ModifiedSaleCommand, ModifiedSaleResult>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;
    private readonly ICalcule _calcule;

    /// <summary>
    /// Initializes a new instance of CreateSaleHandler
    /// </summary>
    /// <param name="saleRepository">The sale repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public ModifiedSaleHandler(ISaleRepository  saleRepository, IMapper mapper, ICalcule calcule)
    {
        _saleRepository = saleRepository;
        _mapper = mapper;
        _calcule = calcule;
    }

    /// <summary>
    /// Handles the CreateSaleCommand request
    /// </summary>
    /// <param name="command">The Createsale command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created sale details</returns>
    public async Task<ModifiedSaleResult> Handle(ModifiedSaleCommand command, CancellationToken cancellationToken)
    {
        var sale = _mapper.Map<Sale>(command);

        var saleDB = await _saleRepository.GetByIdAsync(sale.Id, cancellationToken);
        if (saleDB == null)
        {
            throw new ValidationException("Venda de ID " + sale.Id + " não encntrada.");
        }
        else
        {
            //Deleta itens antigos
            await _saleRepository.DeleteSaleItensAsync(saleDB.Id, cancellationToken);
            
            decimal total = 0;
            foreach (var item in sale.SaleItem)
            {
                item.SaleId = saleDB.Id;
                item.TotalAmount = item.Quantities * _saleRepository.ProductByIdAsync(item.ProductId, cancellationToken).Result.Price;
                total += item.TotalAmount;
                item.UpdatedAt = DateTime.Now;
                item.Status = Domain.Enums.SaleStatus.Active;
                saleDB.SaleItem.Add(item);
            }

            if (!_calcule.QuantityValid(saleDB.SaleItem))
                throw new ValidationException("Não é possível vender mais de 20 itens idênticos.");

            saleDB.Discounts = _calcule.Discount(saleDB.SaleItem);
            saleDB.TotalSaleAmount = _calcule.TotalSaleAmount(total, saleDB.Discounts);
            saleDB.UpdatedAt = DateTime.Now;

            var modifiedSale = await _saleRepository.UpdateAsync(saleDB, cancellationToken);
            var result = _mapper.Map<ModifiedSaleResult>(modifiedSale);
            return result;

        }

    }
}
