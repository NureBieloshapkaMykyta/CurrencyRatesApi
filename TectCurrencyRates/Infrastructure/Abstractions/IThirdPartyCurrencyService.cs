using Shared.Responses;

namespace Infrastructure.Abstractions;

public interface IThirdPartyCurrencyService
{
    Task<CurrencyRateThirdPartyModel> GetCurrencyModels(CancellationToken cancellationToken = default);
}
