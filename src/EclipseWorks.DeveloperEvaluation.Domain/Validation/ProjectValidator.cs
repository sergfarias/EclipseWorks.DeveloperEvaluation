using FluentValidation;
using EclipseWorks.DeveloperEvaluation.Domain.Enums;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;
namespace EclipseWorks.DeveloperEvaluation.Domain.Validation;

public class ProjectValidator : AbstractValidator<Project>
{
    public ProjectValidator()
    {
        RuleFor(project => project.Status)
            .NotEqual(ProjectStatus.Unknown)
            .WithMessage("Status do projeto não pode ser desconhecido.");
    }
}
