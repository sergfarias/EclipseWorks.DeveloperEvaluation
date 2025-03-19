using MediatR;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.ModifiedSale;

/// <summary>
/// Command for modified a new sale.
/// </summary>
/// <remarks>
/// This command is sale to capture the required data for modified a sale, 
/// modified sale number, sale date, customerId, total sale amount, discounts, branchId, status and sale itens. 
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="ModifiedSaleResult"/>.
/// </remarks>
public class ModifiedSaleCommand : IRequest<ModifiedSaleResult>
{
    /// <summary>
    /// Gets or sets the sale for the sale.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the number of the sale to be created.
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the date for the sale.
    /// </summary>
    public DateTime SaleDate { get; set; } 

    /// <summary>
    /// Gets or sets the customer for the sale.
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Gets or sets the total sale amount for the sale.
    /// </summary>
    public decimal TotalSaleAmount { get; set; }

    /// <summary>
    /// Gets or sets the discounts for the sale.
    /// </summary>
    public decimal Discounts { get; set; }

    /// <summary>
    /// Gets or sets the branch for the sale.
    /// </summary>
    public Guid BranchId { get; set; }

    /// <summary>
    /// Gets or sets the status for the sale.
    /// </summary>
    public SaleStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the itens for the sale.
    /// </summary>
    public List<SaleItem> SaleItem { get; set; } = [];

}