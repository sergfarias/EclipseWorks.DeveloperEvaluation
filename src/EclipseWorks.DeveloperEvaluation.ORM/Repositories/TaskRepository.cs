using Microsoft.EntityFrameworkCore;
using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
namespace EclipseWorks.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of ITaskRepository using Entity Framework Core
/// </summary>
public class TaskRepository : ITaskRepository
{
    private readonly Context _context;

    /// <summary>
    /// Initializes a new instance of taskRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public TaskRepository(Context context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new task in the database
    /// </summary>
    /// <param name="user">The task to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created task</returns>
    public async Task<Domain.Entities.Task> CreateAsync(Domain.Entities.Task task, CancellationToken cancellationToken = default)
    {
        await _context.Tasks.AddAsync(task, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return task;
    }

    /// <summary>
    /// Update a task in the database
    /// </summary>
    /// <param name="task">The task to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The update task</returns>
    public async Task<Domain.Entities.Task> UpdateTaskAsync(Domain.Entities.Task projectTask, CancellationToken cancellationToken = default)
    {
        _context.Entry(projectTask).State = EntityState.Modified;
        await _context.SaveChangesAsync(cancellationToken);
        return projectTask;
    }

    /// <summary>
    /// Retrieves a task by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the task</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The task if found, null otherwise</returns>
    public async Task<Domain.Entities.Task?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Tasks.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    /// <summary>
    /// Retrieves as task by taskId identifier
    /// </summary>
    /// <param name="id">The taskId identifier of the task</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The task if found, null otherwise</returns>
    public async Task<List<Domain.Entities.Task>?> TaskByProjectIdAsync(Guid projectId, CancellationToken cancellationToken = default)
    {
        return await _context.Tasks.Where(o => o.ProjectId == projectId).ToListAsync(cancellationToken);
    }

    /// <summary>
    /// Retrieves as task pending by taskId identifier
    /// </summary>
    /// <param name="id">The taskId identifier of the task</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The task if found, null otherwise</returns>
    public async Task<List<Domain.Entities.Task>?> TaskPendingByProjectIdAsync(Guid projectId, CancellationToken cancellationToken = default)
    {
        return await _context.Tasks.Where(o => o.ProjectId == projectId && o.Status == Domain.Enums.TaskStatus.Pending ).ToListAsync(cancellationToken);
    }

    /// <summary>
    /// Deletes a task from the database
    /// </summary>
    /// <param name="id">The unique identifier of the task to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the task was deleted, false if not found</returns>
    public async Task<bool> DeleteTasksAsync(Guid projectId, CancellationToken cancellationToken = default)
    {
        var tasks = await TaskByProjectIdAsync(projectId, cancellationToken);
        if (tasks == null)
            return false;

        _context.Tasks.RemoveRange(tasks);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}
