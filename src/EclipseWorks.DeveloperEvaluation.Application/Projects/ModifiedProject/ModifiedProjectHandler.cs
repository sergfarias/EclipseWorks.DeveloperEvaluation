using MediatR;
using AutoMapper;
using FluentValidation;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;
using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
namespace EclipseWorks.DeveloperEvaluation.Application.Projects.ModifiedProject;

/// <summary>
/// Handler for processing ModifiedSaleCommand requests
/// </summary>
public class ModifiedProjectHandler : IRequestHandler<ModifiedProjectCommand, ModifiedProjectResult>
{
    private readonly IProjectRepository _projectRepository;
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of ModifieldProjectHandler
    /// </summary>
    public ModifiedProjectHandler(IProjectRepository projectRepository, ITaskRepository taskRepository, IMapper mapper)
    {
        _projectRepository = projectRepository;
        _taskRepository = taskRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the ModifieldProjectCommand request
    /// </summary>
    public async Task<ModifiedProjectResult> Handle(ModifiedProjectCommand command, CancellationToken cancellationToken)
    {
        var project = _mapper.Map<Project>(command);

        var projectDB = await _projectRepository.GetByIdAsync(project.Id, cancellationToken);
        if (projectDB == null)
        {
            throw new ValidationException("Projeto de ID " + project.Id + " não encntrada.");
        }
        else
        {
            //Deleta itens antigos
            await _taskRepository.DeleteTasksAsync(projectDB.Id, cancellationToken);
            
            foreach (var item in project.Tasks)
            {
                item.ProjectId = projectDB.Id;
                item.UpdatedAt = DateTime.Now;
                projectDB.Tasks.Add(item);
            }

            projectDB.UpdatedAt = DateTime.Now;

            var modifiedSale = await _projectRepository.UpdateAsync(projectDB, cancellationToken);
            var result = _mapper.Map<ModifiedProjectResult>(modifiedSale);
            return result;

        }

    }
}
