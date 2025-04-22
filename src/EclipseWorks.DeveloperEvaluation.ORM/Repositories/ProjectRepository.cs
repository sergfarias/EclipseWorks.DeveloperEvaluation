using Microsoft.EntityFrameworkCore;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;
using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
namespace EclipseWorks.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of IProjetRepository using Entity Framework Core
/// </summary>
public class ProjectRepository : IProjectRepository
{
    private readonly Context _context;

    /// <summary>
    /// Initializes a new instance of projectRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public ProjectRepository(Context context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new project in the database
    /// </summary>
    /// <param name="user">The projet to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created project</returns>
    public async Task<Project> CreateAsync(Project project, CancellationToken cancellationToken = default)
    {
        await _context.Projects.AddAsync(project, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return project;
    }

    /// <summary>
    /// Update a project in the database
    /// </summary>
    /// <param name="project">The project to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The update project</returns>
    public async Task<Project> UpdateAsync(Project project, CancellationToken cancellationToken = default)
    {
        _context.Entry(project).State = EntityState.Modified;
        await _context.SaveChangesAsync(cancellationToken);
        return project;
    }

    /// <summary>
    /// Deletes a project from the database
    /// </summary>
    /// <param name="id">The unique identifier of the projet to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the project was deleted, false if not found</returns>
    public async Task<bool> DeleteAsync(Guid projectId, CancellationToken cancellationToken = default)
    {
        var project = await GetByIdAsync(projectId, cancellationToken);
        if (project == null)
            return false;

        _context.Projects.RemoveRange(project);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    /// <summary>
    /// Retrieves a project by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the project</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The project if found, null otherwise</returns>
    public async Task<Project?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Projects.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    /// <summary>
    /// Retrieves as projects by IdUser 
    /// </summary>
    /// <param name="id">The IdUser of the project</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The project if found, null otherwise</returns>
    public async Task<List<Project>?> GetProjectsAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        return await _context.Projects.Where(a => a.UserId == userId).ToListAsync(cancellationToken: cancellationToken);
    }
    
}
