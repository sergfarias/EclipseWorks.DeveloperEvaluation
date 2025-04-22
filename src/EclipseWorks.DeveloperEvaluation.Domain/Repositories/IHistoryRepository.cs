using EclipseWorks.DeveloperEvaluation.Domain.Entities;

namespace EclipseWorks.DeveloperEvaluation.Domain.Repositories;

/// <summary>
/// Repository interface for history entity operations
/// </summary>
public interface IHistoryRepository
{
    /// <summary>
    /// Creates a new history in the repository
    /// </summary>
    /// <param name="history">The history to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created history</returns>
    Task<History> CreateAsync(History history, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a history by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the history item</param>
    /// <returns>The history if found, null otherwise</returns>
    Task<History> GetByIdAsync(Guid id);

    /// <summary>
    /// Retrieves a history by their historyId identifier
    /// </summary>
    /// <param name="id">The unique identifier of the history</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The task if found, null otherwise</returns>
    Task<List<History>?> HistoryByTaskIdAsync(Guid projectId, CancellationToken cancellationToken = default);

}
