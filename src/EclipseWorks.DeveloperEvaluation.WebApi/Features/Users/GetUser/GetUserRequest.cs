namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Users.GetUser;

/// <summary>
/// Request model for getting a user by ID
/// </summary>
public class GetProjectRequest
{
    /// <summary>
    /// The unique identifier of the user to retrieve
    /// </summary>
    public Guid Id { get; set; }
}
