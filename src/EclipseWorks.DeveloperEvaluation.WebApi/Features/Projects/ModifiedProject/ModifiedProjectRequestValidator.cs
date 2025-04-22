using FluentValidation;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.ModifiedProject;

/// <summary>
/// Validator for ModifiedProjectRequest that defines validation rules for ModifiedProject.
/// </summary>
public class ModifiedProjectRequestValidator : AbstractValidator<ModifiedProjectRequest>
{
    public ModifiedProjectRequestValidator()
    {
        RuleFor(x => x.Id)
           .NotEmpty()
           .WithMessage("Sale ID is required");

        RuleFor(sale => sale.ProjectNumber).NotEmpty().Length(3, 20);
    }
}