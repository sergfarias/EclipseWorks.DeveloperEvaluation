using AutoMapper;
using MediatR;
using FluentValidation;
using EclipseWorks.DeveloperEvaluation.Domain.Repositories;

namespace EclipseWorks.DeveloperEvaluation.Application.Histories.ListHistory;

/// <summary>
/// Handler for processing ListHistoryCommand requests
/// </summary>
public class ListHistoryHandler : IRequestHandler<ListHistoryCommand, List<ListHistoryResult>>
{
    private readonly IHistoryRepository _historyRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of ListHistoryHandler
    /// </summary>
     public ListHistoryHandler(
        IHistoryRepository historyRepository,
        IMapper mapper)
    {
        _historyRepository = historyRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the GetProjectCommand request
    /// </summary>
     public async Task<List<ListHistoryResult>> Handle(ListHistoryCommand command, CancellationToken cancellationToken)
    {
        var tasks = await _historyRepository.HistoryByTaskIdAsync(command.IdTask, cancellationToken);
        if (tasks == null)
            throw new KeyNotFoundException($"Histories not found");
        return _mapper.Map<List<ListHistoryResult>>(tasks);
    }
}
