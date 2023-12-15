using Rootwire.Hilltop.Domain.Entities.Test;

namespace Rootwire.Hilltop.Domain.Test.Entities.Test;

public class AggregateTests
{
    [Theory]
    [InlineData("Remote Vulnerability Assessment", "remote-vulnerability-assessment")]
    [InlineData("Check patching, by authenticated vuln scan", "check-patching-by-authenticated-vuln-scan")]
    [InlineData("Check malware protection", "check-malware-protection")]
    public void Identifier_Is_Generated_Correctly(string input, string expectedOutput)
    {
        Aggregate _sut = new Aggregate
        {
            Identifier = input
        };
        Assert.NotNull(_sut.Identifier);
        Assert.Equal(expectedOutput, _sut.Identifier);
    }
    
    [Theory]
    [InlineData("Remote Vulnerability Assessment", "aggregate:remote-vulnerability-assessment")]
    [InlineData("Check patching, by authenticated vuln scan", "aggregate:check-patching-by-authenticated-vuln-scan")]
    [InlineData("Check malware protection", "aggregate:check-malware-protection")]
    public void ReferenceTag_Is_Generated_Correctly(string input, string expectedOutput)
    {
        Aggregate _sut = new Aggregate
        {
            Identifier = input
        };
        Assert.NotNull(_sut.ReferenceTag);
        Assert.Equal(expectedOutput, _sut.ReferenceTag);
    }
}