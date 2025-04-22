using EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.DeleteTask;
using FluentValidation;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Tasks.DeleteTask.DeleteTask;

/// <summary>
/// Validator for DeleteTaskRequest
/// </summary>
public class DeleteTaskRequestValidator : AbstractValidator<DeleteTaskRequest>
{
    /// <summary>
    /// Initializes validation rules for DeleteProjectRequest
    /// </summary>
    public DeleteTaskRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Task ID is required");
    }
}
