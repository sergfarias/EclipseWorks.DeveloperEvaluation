using Microsoft.EntityFrameworkCore;
using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;
namespace EclipseWorks.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of IHistoryRepository using Entity Framework Core
/// </summary>
public class HistoryRepository : IHistoryRepository
{
    private readonly Context _context;

    /// <summary>
    /// Initializes a new instance of historyRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public HistoryRepository(Context context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new history in the database
    /// </summary>
    /// <param name="user">The history to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created history</returns>
    public async Task<History> CreateAsync(History history, CancellationToken cancellationToken = default)
    {
        await _context.Histories.AddAsync(history, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return history;
    }

    /// <summary>
    /// Retrieves a history by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the task</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The history if found, null otherwise</returns>
    public async Task<History?> GetByIdAsync(Guid id)
    {
        return await _context.Histories.FirstOrDefaultAsync(o => o.Id == id);
    }

    /// <summary>
    /// Retrieves as history by historyId identifier
    /// </summary>
    /// <param name="id">The historyId identifier of the history</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The history if found, null otherwise</returns>
    public async Task<List<History>?> HistoryByTaskIdAsync(Guid taskId, CancellationToken cancellationToken = default)
    {
        return await _context.Histories.Where(o => o.TaskId == taskId).ToListAsync(cancellationToken);
    }

}
