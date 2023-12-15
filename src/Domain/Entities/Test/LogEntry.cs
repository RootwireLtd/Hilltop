using Rootwire.Hilltop.Domain.Common;

namespace Rootwire.Hilltop.Domain.Entities.Test;

public class LogEntry : BaseAuditableEntity
{
    private const string _prefix = "testlog";
    
    private string _assessmentDescriptor;
    public TestCase TestCase { get; set; }
    public bool IsSuccess { get; set; }
    public string TestResultDetail { get; set; }

    public string AssessmentDescriptor
    {
        get => _assessmentDescriptor;
        set { SetAssessmentDescriptor(); }
    }

    public void SetAssessmentDescriptor()
    {
        var authorityReferenceTag = TestCase.Aggregate.Specification.Authority.ReferenceTag;
        var specificationReferenceTag = TestCase.Aggregate.Specification.ReferenceTag;
        var aggregateReferenceTag = TestCase.Aggregate.ReferenceTag;
        var testcaseReferenceTag = TestCase.ReferenceTag;
        var resultText = IsSuccess ? "success-result" : "failed-result";
        
        string assessmentDescriptor = $"{authorityReferenceTag} > {specificationReferenceTag} > {aggregateReferenceTag} > {testcaseReferenceTag} > {_prefix}:{resultText}";

        _assessmentDescriptor = assessmentDescriptor;
    }
}