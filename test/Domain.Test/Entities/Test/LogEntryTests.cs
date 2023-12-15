using Rootwire.Hilltop.Domain.Entities;
using Rootwire.Hilltop.Domain.Entities.Test;

namespace Rootwire.Hilltop.Domain.Test.Entities.Test;

public class LogEntryTests
{
    [Fact]
    public void GetAssessmentDescriptor_Generates_Correct_Result()
    {
        Authority authority = new Authority()
        {
            Identifier = "CyberEssentials"
        };
        

        Specification specification = new Specification()
        {
            Authority = authority,
            Identifier = "Cyber-Essentials-Plus-Illustrative-Technical-Specification-v3-1-January-2023"
        };

        Aggregate aggregate = new Aggregate()
        {
            Specification = specification,
            Identifier = "Remote Vulnerability Assessment"
        };

        TestCase testCase = new TestCase()
        {
            Aggregate = aggregate,
            Identifier = "Authentication required to access service"
        };

        LogEntry logEntry = new LogEntry()
        {
            TestCase = testCase,
            IsSuccess = true
        };

        logEntry.SetAssessmentDescriptor();
        
        Assert.NotNull(logEntry.AssessmentDescriptor);;
        string expectedOutput = "authority:cyberessentials > spec:cyber-essentials-plus-illustrative-technical-specification-v3-1-january-2023 > aggregate:remote-vulnerability-assessment > testcase:authentication-required-to-access-service > testlog:success-result";
        Assert.Equal(expectedOutput,logEntry.AssessmentDescriptor);
    }
}