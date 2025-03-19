using MediatR;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.CancelledSale;

/// <summary>
/// Command for cancelled a sale.
/// </summary>
/// <remarks>
/// This command is sale to capture the required data for cancelled a sale, 
/// including sale number, sale date, customerId, total sale amount, discounts, branchId, status and sale itens. 
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="CancelledSaleResult"/>.
/// </remarks>
public class CancelledSaleCommand : IRequest<CancelledSaleResult>
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