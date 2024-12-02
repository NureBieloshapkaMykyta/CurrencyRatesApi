using Shared.Requests;
using Shared.Responses;

namespace Business.Abstractions;

public interface ICurrencyService
{
    Task<List<CurrencyInfoResponse>> GetCurrencyBySymbolAsync(GetCurrencyBySymbolRequest request, CancellationToken cancellationToken = default);}
