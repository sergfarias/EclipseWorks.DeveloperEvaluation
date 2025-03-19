using Microsoft.EntityFrameworkCore;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of ISaleRepository using Entity Framework Core
/// </summary>
public class SaleRepository : ISaleRepository
{
    private readonly Context _context;

    /// <summary>
    /// Initializes a new instance of saleRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public SaleRepository(Context context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new sale in the database
    /// </summary>
    /// <param name="user">The sale to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created sale</returns>
    public async Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default)
    {
        await _context.Sales.AddAsync(sale, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return sale;
    }

    /// <summary>
    /// Update a sale in the database
    /// </summary>
    /// <param name="user">The sale to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The update sale</returns>
    public async Task<Sale> UpdateAsync(Sale sale, CancellationToken cancellationToken = default)
    {
        _context.Entry(sale).State = EntityState.Modified;
        await _context.SaveChangesAsync(cancellationToken);
        return sale;
    }

    /// <summary>
    /// Update a sale item in the database
    /// </summary>
    /// <param name="user">The sale item to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The update sale item</returns>
    public async Task<SaleItem> UpdateSaleItemAsync(SaleItem saleItem, CancellationToken cancellationToken = default)
    {
        _context.Entry(saleItem).State = EntityState.Modified;
        await _context.SaveChangesAsync(cancellationToken);
        return saleItem;
    }

    /// <summary>
    /// Retrieves a sale by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the sale</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user if found, null otherwise</returns>
    public async Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Sales.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    /// <summary>
    /// Retrieves a product by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the product</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The product if found, null otherwise</returns>
    public async Task<Product?> ProductByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Products.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    /// <summary>
    /// Retrieves a sale item by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the sale item</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The product if found, null otherwise</returns>
    public async Task<SaleItem?> SaleItemByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.SaleItems.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    /// <summary>
    /// Retrieves a sale item by their saleId identifier
    /// </summary>
    /// <param name="id">The unique identifier of the sale</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The product if found, null otherwise</returns>
    public async Task<List<SaleItem>?> SaleItensBySaleIdAsync(Guid saleId, CancellationToken cancellationToken = default)
    {
        return await _context.SaleItems.Where(o => o.SaleId == saleId).ToListAsync(cancellationToken);
        //return await _context.SaleItems.FirstOrDefaultAsync(o => o.SaleId == saleId, cancellationToken);
    }

    /// <summary>
    /// Deletes a user from the database
    /// </summary>
    /// <param name="id">The unique identifier of the user to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the user was deleted, false if not found</returns>
    public async Task<bool> DeleteSaleItensAsync(Guid saleId, CancellationToken cancellationToken = default)
    {
        var saleItens = await SaleItensBySaleIdAsync(saleId, cancellationToken);
        if (saleItens == null)
            return false;

        _context.SaleItems.RemoveRange(saleItens);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
