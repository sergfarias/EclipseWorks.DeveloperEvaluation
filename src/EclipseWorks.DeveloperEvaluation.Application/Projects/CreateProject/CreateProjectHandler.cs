using AutoMapper;
using MediatR;
using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;
namespace EclipseWorks.DeveloperEvaluation.Application.Projects.CreateProject;

/// <summary>
/// Handler for processing CreateSaleCommand requests
/// </summary>
public class CreateProjectHandler : IRequestHandler<CreateProjectCommand, CreateProjectResult>
{
    private readonly IProjectRepository _projectRepository;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
  
    /// <summary>
    /// Initializes a new instance of CreateProjectHandler
    /// </summary>
    public CreateProjectHandler(IProjectRepository  projectRepository, IUserRepository userRepository, IMapper mapper)
    {
        _projectRepository = projectRepository;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the CreateProjectCommand request
    /// </summary>
    public async Task<CreateProjectResult> Handle(CreateProjectCommand command, CancellationToken cancellationToken)
    {
        var project = _mapper.Map<Project>(command);
        project.Id = Guid.NewGuid();

        _ = await _userRepository.GetByIdAsync(project.UserId, cancellationToken) ?? throw new KeyNotFoundException("Usuário (" + project.UserId + ") do projeto não encontrado.");
        
        if (project?.Tasks?.Count > 20)
        {
            throw new InvalidOperationException("Projeto não pode ter mais e 20 tarefas.");
        }

        foreach (var item in project.Tasks)
        {
            item.ProjectId = project.Id;
            item.CreatedAt = DateTime.Now;
            item.Status = Domain.Enums.TaskStatus.Pending;
        }
        project.Status = Domain.Enums.ProjectStatus.Active;
        project.CreatedAt = DateTime.Now;

        var createdProject = await _projectRepository.CreateAsync(project, cancellationToken);
        var result = _mapper.Map<CreateProjectResult>(createdProject);
        return result;
    }
}
