using FluentValidation;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.CreateTask;

/// <summary>
/// Validator for CreateTaskRequest that defines validation rules for task creation.
/// </summary>
public class CreateTaskRequestValidator : AbstractValidator<CreateTaskRequest>
{
    public CreateTaskRequestValidator()
    {
          RuleFor(task => task.ProjectId).NotEmpty();
          RuleFor(task => task.Priority).NotEmpty();
    }
}