using Rootwire.Hilltop.Domain.Entities.Test;

namespace Rootwire.Hilltop.Domain.Test.Entities.Test;

public class TestCaseTests
{
    [Theory]
    [InlineData("1.2.1", "1.2.1")]
    [InlineData("Authentication required to access service", "authentication-required-to-access-service")]
    public void Identifier_Is_Generated_Correctly(string input, string expectedOutput)
    {
        TestCase _sut = new TestCase
        {
            Identifier = input
        };
        Assert.NotNull(_sut.Identifier);
        Assert.Equal(expectedOutput, _sut.Identifier);
    }
    
    [Theory]
    [InlineData("1.2.1", "testcase:1.2.1")]
    [InlineData("Authentication required to access service", "testcase:authentication-required-to-access-service")]
    public void ReferenceTag_Is_Generated_Correctly(string input, string expectedOutput)
    {
        TestCase _sut = new TestCase
        {
            Identifier = input
        };
        Assert.NotNull(_sut.ReferenceTag);
        Assert.Equal(expectedOutput, _sut.ReferenceTag);
    }
}