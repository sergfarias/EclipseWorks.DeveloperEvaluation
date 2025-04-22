using MediatR;
using AutoMapper;
using FluentValidation;
using EclipseWorks.DeveloperEvaluation.Domain.Repositories;

namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.UpdateTask;

/// <summary>
/// Handler for processing CancelledTaskCommand requests
/// </summary>
public class UpdateTaskHandler : IRequestHandler<UpdateTaskCommand, UpdateTaskResult>
{
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of CancelledTaskHandler
    /// </summary>
    public UpdateTaskHandler(ITaskRepository taskRepository, IMapper mapper)
    {
        _taskRepository = taskRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the CancelledTaskCommand request
    /// </summary>
    public async Task<UpdateTaskResult> Handle(UpdateTaskCommand command, CancellationToken cancellationToken)
    {
        var task = _mapper.Map<Domain.Entities.Task>(command);

       var taskDB = await _taskRepository.GetByIdAsync(task.Id, cancellationToken);
        if (taskDB == null)
        {
            throw new ValidationException("Tarefa de ID " + task.Id + " não encntrada.");
        }
        else {
            if (task.Status>0) 
                taskDB.Status = task.Status; 
           
            if (!string.IsNullOrEmpty(task.Details))
                taskDB.Details = task.Details;

            taskDB.UpdatedAt = DateTime.Now;
        }

        var updateTask = await _taskRepository.UpdateTaskAsync(taskDB, cancellationToken);
        var result = _mapper.Map<UpdateTaskResult>(updateTask);
        return result;
    }
}
