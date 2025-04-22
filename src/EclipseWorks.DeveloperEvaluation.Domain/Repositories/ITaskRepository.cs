namespace EclipseWorks.DeveloperEvaluation.Domain.Repositories;

/// <summary>
/// Repository interface for task entity operations
/// </summary>
public interface ITaskRepository
{
    /// <summary>
    /// Creates a new task in the repository
    /// </summary>
    /// <param name="task">The task to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created task</returns>
    Task<Entities.Task> CreateAsync(Entities.Task task, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a task in the repository
    /// </summary>
    /// <param name="task">The task to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The update task</returns>
    Task<Entities.Task> UpdateTaskAsync(Entities.Task task, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a tasks from the database
    /// </summary>
    /// <param name="id">The unique identifier of the task to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the task was deleted, false if not found</returns>
    Task<bool> DeleteTasksAsync(Guid projectId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a task by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the task</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The task if found, null otherwise</returns>
    Task<Entities.Task> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a task by their projectId identifier
    /// </summary>
    /// <param name="id">The unique identifier of the project</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The product if found, null otherwise</returns>
    Task<List<Entities.Task>?> TaskByProjectIdAsync(Guid projectId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a task by their projectId identifier
    /// </summary>
    /// <param name="id">The unique identifier of the project</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The product if found, null otherwise</returns>
    Task<List<Entities.Task>?> TaskPendingByProjectIdAsync(Guid projectId, CancellationToken cancellationToken = default);

}
