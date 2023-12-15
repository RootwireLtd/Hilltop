using Microsoft.AspNetCore.Mvc;
using Rootwire.Hilltop.Api.Models.Request;

namespace Rootwire.Hilltop.Api.Controllers;

[Route("testlog")]
public class TestLogController : Controller
{
    [HttpPost("")]
    public object? PostLogEntry(TestResultRequestModel requestModel)
    {
        throw new NotImplementedException();
    }
}