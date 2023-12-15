using Rootwire.Hilltop.Domain.Entities.Test;

namespace Rootwire.Hilltop.Domain.Test.Entities.Test;

public class SpecificationTests
{
    [Theory]
    [InlineData("2023 10 31", "2023-10-31")]
    [InlineData("Cyber-Essentials-Plus-Illustrative-Technical-Specification-v3-1-January-2023.pdf", "cyber-essentials-plus-illustrative-technical-specification-v3-1-january-2023.pdf")]
    public void Identifier_Is_Generated_Correctly(string input, string expectedOutput)
    {
        Specification _sut = new Specification
        {
            Identifier = input
        };
        Assert.NotNull(_sut.Identifier);
        Assert.Equal(expectedOutput, _sut.Identifier);
    }
    
    [Theory]
    [InlineData("2023 10 31", "spec:2023-10-31")]
    [InlineData("Cyber-Essentials-Plus-Illustrative-Technical-Specification-v3-1-January-2023.pdf", "spec:cyber-essentials-plus-illustrative-technical-specification-v3-1-january-2023.pdf")]
    public void ReferenceTag_Is_Generated_Correctly(string input, string expectedOutput)
    {
        Specification _sut = new Specification
        {
            Identifier = input
        };
        Assert.NotNull(_sut.ReferenceTag);
        Assert.Equal(expectedOutput, _sut.ReferenceTag);
    }
}