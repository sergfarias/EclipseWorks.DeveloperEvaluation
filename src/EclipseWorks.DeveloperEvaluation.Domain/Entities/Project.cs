using EclipseWorks.DeveloperEvaluation.Domain.Enums;
using EclipseWorks.DeveloperEvaluation.Domain.Common;
using EclipseWorks.DeveloperEvaluation.Common.Security;
using EclipseWorks.DeveloperEvaluation.Common.Validation;
using EclipseWorks.DeveloperEvaluation.Domain.Validation;

namespace EclipseWorks.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a project in the system .
/// </summary>
public class Project : BaseEntity, IProject
{
    public string ProjectNumber { get; set; } = string.Empty;

    public DateTime ProjectDate { get; set; }

    public Guid UserId { get; set; }

    public User? User { get; set; }

    public List<Task>? Tasks { get; set; }

    public ProjectStatus Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    string IProject.Id => Id.ToString();

    string IProject.ProjectNumber => ProjectNumber;

    DateTime IProject.ProjectDate => ProjectDate;

    Guid IProject.UserId => UserId;


    public Project() => CreatedAt = DateTime.UtcNow;

    /// <summary>
    /// Performs validation of the user entity using the ProjectValidator rules.
    /// </summary>
    public ValidationResultDetail Validate()
    {
        var validator = new ProjectValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }

    /// <summary>
    /// Activates the project.
    /// </summary>
    public void Activate()
    {
        Status = ProjectStatus.Active;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Cancelled the project.
    /// </summary>
    public void Deactivate()
    {
        Status = ProjectStatus.Cancelled;
        UpdatedAt = DateTime.UtcNow;
    }

}