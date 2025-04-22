using EclipseWorks.DeveloperEvaluation.Domain.Entities;
using EclipseWorks.DeveloperEvaluation.Domain.Enums;

namespace EclipseWorks.DeveloperEvaluation.Domain.Specifications;

public class ActiveUserSpecification : ISpecification<User>
{
    public bool IsSatisfiedBy(User user)
    {
        return user.Status == UserStatus.Active;
    }
}
