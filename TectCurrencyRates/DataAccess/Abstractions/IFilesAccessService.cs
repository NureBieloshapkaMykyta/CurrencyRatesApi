using Shared.Responses;

namespace DataAccess.Abstractions;

public interface IFilesAccessService
{
    Task CacheCurrencies(List<CurrencyInfoResponse> data, CancellationToken cancellationToken = default);
    Task CacheCourses(List<GetCoursesResponse> data, CancellationToken cancellationToken = default);
}
