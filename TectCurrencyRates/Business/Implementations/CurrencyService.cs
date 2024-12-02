using AutoMapper;
using Business.Abstractions;
using DataAccess.Abstractions;
using Infrastructure.Abstractions;
using Shared.Options;
using Shared.Requests;
using Shared.Responses;

namespace Business.Implementations;

public class CurrencyService(IThirdPartyCurrencyService service, IFilesAccessService accessService, IMapper mapper) : ICurrencyService
{
    public async Task<List<CurrencyInfoResponse>> GetCurrencyBySymbolAsync(GetCurrencyBySymbolRequest request, CancellationToken cancellationToken = default)
    {
		try
		{
			var data = await service.GetCurrencyModels(cancellationToken);

			var response = mapper.Map<List<CurrencyInfoResponse>>(data);

			if (RefreshCache.LastRefreshed.AddMinutes(10) < DateTime.UtcNow) 
			{
				await accessService.CacheCurrencies(response);
			}
			
			return response;
		}
		catch
		{
			//get from cache
			throw;
		}
    }
}
