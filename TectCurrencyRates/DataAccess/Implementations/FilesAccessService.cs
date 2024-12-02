
using DataAccess.Abstractions;
using Shared;
using Shared.Responses;
using System.Text.Json;

namespace DataAccess.Implementations;

public class FilesAccessService : IFilesAccessService
{
    public async Task CacheCourses(List<GetCoursesResponse> data, CancellationToken cancellationToken = default)
    {
        using var fileStream = new StreamWriter(PathConstants.Cache + "/" + PathConstants.Courses);
        await fileStream.WriteAsync(JsonSerializer.Serialize(data));
    }

    public async Task CacheCurrencies(List<CurrencyInfoResponse> data, CancellationToken cancellationToken = default)
    {
        using var fileStream = new StreamWriter(PathConstants.Cache + "/" + PathConstants.Currencies);
        await fileStream.WriteAsync(JsonSerializer.Serialize(data));
    }
}
