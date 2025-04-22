using FluentValidation;
namespace EclipseWorks.DeveloperEvaluation.Application.Projects.DeleteProject;

/// <summary>
/// Validator for DeleteProjectCommand
/// </summary>
public class DeleteProjectValidator : AbstractValidator<DeleteProjectCommand>
{
    /// <summary>
    /// Initializes validation rules for DeleteProjectCommand
    /// </summary>
    public DeleteProjectValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Project ID is required");
    }
}
