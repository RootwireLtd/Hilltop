using Rootwire.Hilltop.Domain.Entities;

namespace Rootwire.Hilltop.Domain.Test.Entities;

public class AuthorityTests
{
    [Theory]
    [InlineData("Cyberessentials", "cyberessentials")]
    [InlineData("Long Company Name 35", "long-company-name-35")]
    public void Identifier_Is_Generated_Correctly(string input, string expectedOutput)
    {
        Authority _sut = new Authority
        {
            Identifier = input
        };
        Assert.NotNull(_sut.Identifier);
        Assert.Equal(expectedOutput, _sut.Identifier);
    }
    
    [Theory]
    [InlineData("Cyberessentials", "authority:cyberessentials")]
    [InlineData("Long Company Name 35", "authority:long-company-name-35")]
    public void ReferenceTag_Is_Generated_Correctly(string input, string expectedOutput)
    {
        Authority _sut = new Authority
        {
            Identifier = input
        };
        Assert.NotNull(_sut.ReferenceTag);
        Assert.Equal(expectedOutput, _sut.ReferenceTag);
    }
    
}