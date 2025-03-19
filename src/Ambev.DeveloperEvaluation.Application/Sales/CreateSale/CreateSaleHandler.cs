using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Services.Calcule;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Handler for processing CreateSaleCommand requests
/// </summary>
public class CreateSaleHandler : IRequestHandler<CreateSaleCommand, CreateSaleResult>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;
    private readonly ICalcule _calcule;

    /// <summary>
    /// Initializes a new instance of CreateSaleHandler
    /// </summary>
    /// <param name="saleRepository">The sale repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public CreateSaleHandler(ISaleRepository  saleRepository, IMapper mapper, ICalcule calcule)
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
    public async Task<CreateSaleResult> Handle(CreateSaleCommand command, CancellationToken cancellationToken)
    {
        var sale = _mapper.Map<Sale>(command);
      
        sale.Id = Guid.NewGuid();

        if (!_calcule.QuantityValid(sale.SaleItem))
            throw new ValidationException("Não é possível vender mais de 20 itens idênticos.");

        sale.Discounts = _calcule.Discount(sale.SaleItem);

        decimal total = 0;
        foreach(var item in sale.SaleItem)
        {
            item.SaleId = sale.Id;
            item.TotalAmount = item.Quantities * _saleRepository.ProductByIdAsync(item.ProductId, cancellationToken).Result.Price;
            item.CreatedAt = DateTime.Now;
            item.Status = Domain.Enums.SaleStatus.Active;
            total += item.TotalAmount;
        }
        
        sale.TotalSaleAmount = _calcule.TotalSaleAmount(total, sale.Discounts);
        sale.Status = Domain.Enums.SaleStatus.Active;
        sale.CreatedAt = DateTime.Now;

        var createdSale = await _saleRepository.CreateAsync(sale, cancellationToken);
        var result = _mapper.Map<CreateSaleResult>(createdSale);
        return result;
    }
}
