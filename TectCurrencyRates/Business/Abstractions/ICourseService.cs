using Shared.Responses;

namespace Business.Abstractions;

public interface ICourseService
{
    Task<List<GetCoursesResponse>> GetCourseAsync(CancellationToken cancellationToken = default);
}
