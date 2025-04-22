using FluentValidation;

namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.UpdateTask;

/// <summary>
/// Validator for CancelledSaleRequest that defines validation rules for task updation.
/// </summary>
public class UpdateTaskRequestValidator : AbstractValidator<UpdateTaskRequest>
{
    public UpdateTaskRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Task ID is required");
    }
}