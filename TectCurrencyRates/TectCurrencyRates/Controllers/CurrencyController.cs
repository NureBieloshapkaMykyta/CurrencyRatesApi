using Business.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Shared.Requests;

namespace TectCurrencyRates.Controllers;

[ApiController]
[Route("[controller]")]
public class CurrencyController(ICurrencyService service) : Controller
{
    [HttpGet("{symbol}")]
    public async Task<IActionResult> GetCurrenciesBySymbol(string symbol,CancellationToken cancellationToken = default)
    {
        var result = await service.GetCurrencyBySymbolAsync(new GetCurrencyBySymbolRequest(symbol),cancellationToken);

        return Ok(result);
    }
}
