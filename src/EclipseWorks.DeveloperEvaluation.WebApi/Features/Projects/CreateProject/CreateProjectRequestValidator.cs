using FluentValidation;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.CreateProject;

/// <summary>
/// Validator for CreateProjectRequest that defines validation rules for project creation.
/// </summary>
public class CreateProjectRequestValidator : AbstractValidator<CreateProjectRequest>
{
    public CreateProjectRequestValidator()
    {
        RuleFor(project => project.ProjectNumber).NotEmpty().Length(3, 20);
        RuleFor(project => project.UserId).NotEmpty();
    }
}