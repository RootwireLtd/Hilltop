namespace Rootwire.Hilltop.Api.Models.Request;

public class TestResultRequestModel
{
    public Guid TestRuleId { get; init; }
    public bool IsSuccess { get; init; }
    public string TestResultDetail { get; init; }
}