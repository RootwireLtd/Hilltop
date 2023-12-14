using System.Collections;
using Rootwire.Hilltop.Domain.Extensions;
using Rootwire.Hilltop.Domain.Test.Helpers;
using Xunit.Abstractions;

namespace Rootwire.Hilltop.Domain.Test.Extensions;

public class StringExtensionsTests
{
    private readonly ITestOutputHelper _output;
    
    public StringExtensionsTests(ITestOutputHelper output)
    {
        _output = output;
    }
    
    [Theory]
    [ClassData(typeof(RemoveSpecialCharacterTestData))]
    public void RemoveSpecialCharactersTests(string input, string expectedOutput)
    {
        string actualOutput = input.RemoveSpecialCharacters();
        _output.WriteLine(actualOutput);
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Theory]
    [ClassData(typeof(GenerateEntityIdentifierTestData))]
    public void GenerateEntityIdentifierTests(string input, string expectedOutput)
    {
        string actualOutput = input.GenerateEntityIdentifier();
        _output.WriteLine(actualOutput);
        Assert.Equal(expectedOutput, actualOutput);
    }
}

public class RemoveSpecialCharacterTestData : IEnumerable<object[]>
{
    public static string Utf8Charset = Utilities.GenerateUtf8Characters();
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { Utf8Charset, ".0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ_abcdefghijklmnopqrstuvwxyz" };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class GenerateEntityIdentifierTestData : IEnumerable<object[]>
{
    public static string Utf8Charset = Utilities.GenerateUtf8Characters();
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { Utf8Charset, "-.0123456789abcdefghijklmnopqrstuvwxyz-abcdefghijklmnopqrstuvwxyz-" };
        yield return new object[] { "!ExpEc\"ted 50 g@rbl3d d47*", "expected-50-grbl3d-d47" };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
