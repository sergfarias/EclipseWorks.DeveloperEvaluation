using MediatR;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.CancelledSaleItem;

/// <summary>
/// Command for cancelled a sale item.
/// </summary>
/// <remarks>
/// This command is sale item to capture the required data for cancelled a sale item, 
/// including id, status and sale itens. 
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="CancelledSaleItemResult"/>.
/// </remarks>
public class CancelledSaleItemCommand : IRequest<CancelledSaleItemResult>
{
    /// <summary>
    /// Gets or sets the sale for the sale.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the status for the sale.
    /// </summary>
    public SaleStatus Status { get; set; }

}