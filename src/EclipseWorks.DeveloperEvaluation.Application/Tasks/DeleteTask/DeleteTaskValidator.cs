using FluentValidation;
namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.DeleteTask;

/// <summary>
/// Validator for DeleteTaskCommand
/// </summary>
public class DeleteTaskValidator : AbstractValidator<DeleteTaskCommand>
{
    /// <summary>
    /// Initializes validation rules for DeleteTaskCommand
    /// </summary>
    public DeleteTaskValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Task ID is required");
    }
}
