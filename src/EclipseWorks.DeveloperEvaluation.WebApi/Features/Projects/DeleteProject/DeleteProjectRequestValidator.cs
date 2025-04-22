using EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.DeleteProject;
using FluentValidation;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Projects.DeleteProject.DeleteUser;

/// <summary>
/// Validator for DeleteProjectRequest
/// </summary>
public class DeleteProjectRequestValidator : AbstractValidator<DeleteProjectRequest>
{
    /// <summary>
    /// Initializes validation rules for DeleteProjectRequest
    /// </summary>
    public DeleteProjectRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Project ID is required");
    }
}
