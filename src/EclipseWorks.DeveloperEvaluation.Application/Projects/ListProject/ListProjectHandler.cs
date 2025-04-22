using AutoMapper;
using MediatR;
using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
namespace EclipseWorks.DeveloperEvaluation.Application.Projects.ListProject;

/// <summary>
/// Handler for processing GetProjectCommand requests
/// </summary>
public class ListProjectHandler: IRequestHandler<ListProjectCommand, List<ListProjectResult>>
{
    private readonly IProjectRepository _projectRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of ListProjectHandler
    /// </summary>
    public ListProjectHandler(
        IProjectRepository projectRepository,
        IMapper mapper)
    {
        _projectRepository = projectRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the ListProjectCommand request
    /// </summary>
    public async Task<List<ListProjectResult>> Handle(ListProjectCommand command, CancellationToken cancellationToken)
    {
        var projects = await _projectRepository.GetProjectsAsync(command.IdUser, cancellationToken);
        if (projects == null)
            throw new KeyNotFoundException($"Projects not found");
       
        return _mapper.Map<List<ListProjectResult>>(projects);
    }
}
