using Business.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace TectCurrencyRates.Controllers;

[Route("[controller]")]
public class CourseController(ICourseService service) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken = default)
    {
        var result = await service.GetCourseAsync(cancellationToken);

        return Ok(result);
    }
}
