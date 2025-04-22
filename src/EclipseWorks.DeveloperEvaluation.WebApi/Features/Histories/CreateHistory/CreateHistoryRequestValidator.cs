using FluentValidation;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Histories.CreateHistory;

/// <summary>
/// Validator for CreateHistoryRequest that defines validation rules for history creation.
/// </summary>
public class CreateHistoryRequestValidator : AbstractValidator<CreateHistoryRequest>
{
      public CreateHistoryRequestValidator()
    {
          RuleFor(history => history.TaskId).NotEmpty();
    }
}