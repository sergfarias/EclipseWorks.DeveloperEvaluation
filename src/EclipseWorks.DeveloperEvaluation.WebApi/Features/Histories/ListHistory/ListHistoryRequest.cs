namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Histories.ListHistory;

/// <summary>
/// Represents a request to list of the history by idHistory in the system.
/// </summary>
public class ListHistoryRequest
{
    public Guid IdTask { get; set; }
    
}