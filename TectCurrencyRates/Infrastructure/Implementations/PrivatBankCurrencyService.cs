using Infrastructure.Abstractions;
using Microsoft.Extensions.Options;
using Shared.Options;
using Shared.Responses;
using System.Text.Json;

namespace Infrastructure.Implementations;

public class PrivatBankCurrencyService(IOptions<PrivatBankOptions> options, HttpClient httpClient) : IThirdPartyCurrencyService
{
    public async Task<CurrencyRateThirdPartyModel> GetCurrencyModels(CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await httpClient.GetAsync(options.Value.CurrenciesUrl);
            var data = await JsonSerializer.DeserializeAsync<CurrencyRateThirdPartyModel>(response.Content.ReadAsStream());

            return data!;
        }
        catch
        {
            throw;
        }
    }
}
