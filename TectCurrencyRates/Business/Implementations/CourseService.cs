using Business.Abstractions;
using Shared.Responses;

namespace Business.Implementations;

public class CourseService : ICourseService
{
    public Task<List<GetCoursesResponse>> GetCourseAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
