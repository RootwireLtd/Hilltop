using Microsoft.AspNetCore.Mvc;
using Rootwire.Hilltop.Api.Controllers;
using Rootwire.Hilltop.Api.Models.Request;

namespace Rootwire.Hilltop.Api.Test.Controllers;


public class TestLogControllerTests : IDisposable
{

    private readonly TestLogController _sut;

    public TestLogControllerTests()
    {
        _sut = new TestLogController();
    }
    
    // A POST with Valid data should return 201 Created
    [Fact]
    public void Post_ValidRequest_Returns_Status401()
    {
        var requestModel = new TestResultRequestModel
        {
            TestRuleId = Guid.NewGuid(),
            IsSuccess = true,
            TestResultDetail = "{}"
        };
        var response = _sut.PostLogEntry(requestModel);
        Assert.NotNull(response);
        Assert.IsType<CreatedResult>(response);
    }

    // A POST with Invalid data should return 400 Bad Request
    [Fact]
    void Post_BadRequest_Returns_Status400()
    {
        
        //Assert.IsType<BadRequestResult>(response);
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        _sut?.Dispose();
    }
}