using CoffeeCards.Domain.Shared;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCards.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class ApiController : ControllerBase
{
    protected IActionResult HandleResult(Result result)
    {
        if (result.IsSuccess)
        {
            return Ok();
        }

        return result.Error != null
            ? CreateProblemDetails(result.Error)
            : BadRequest();
    }

    protected IActionResult HandleResult<T>(ResultT<T> result)
    {
        if (result.IsSuccess)
        {
            return Ok(result.Value);
        }

        return result.Error != null
            ? CreateProblemDetails(result.Error)
            : BadRequest();
    }

    private IActionResult CreateProblemDetails(Error error)
    {
        return BadRequest(new ProblemDetails
        {
            Title = error.Code,
            Detail = error.Description,
            Status = StatusCodes.Status400BadRequest
        });
    }
}