using EclipseWorks.DeveloperEvaluation.Domain.Entities;

namespace EclipseWorks.DeveloperEvaluation.Domain.Repositories;

/// <summary>
/// Repository interface for project entity operations
/// </summary>
public interface IProjectRepository
{
    /// <summary>
    /// Creates a new project in the repository
    /// </summary>
    /// <param name="user">The project to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created project</returns>
    Task<Project> CreateAsync(Project project, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a project in the repository
    /// </summary>
    /// <param name="user">The project to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The update project</returns>
    Task<Project> UpdateAsync(Project project, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a project from the database
    /// </summary>
    /// <param name="id">The unique identifier of the project to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the project was deleted, false if not found</returns>
    Task<bool> DeleteAsync(Guid projectId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a project by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the project</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The sale if found, null otherwise</returns>
    Task<Project?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<List<Project>?> GetProjectsAsync(Guid userId, CancellationToken cancellationToken = default);
    
}
