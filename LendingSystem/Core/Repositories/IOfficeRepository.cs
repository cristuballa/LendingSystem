using LendingSystem.Core.Domain;
using System.Collections.Generic;


namespace LendingSystem.Core.Repositories
{
    public interface IOfficeRepository : IRepository<Office>
    {
        IEnumerable<Office> GetTopSellingCourses(int count);
        //    IEnumerable<Borrower> GetCoursesWithAuthors(int pageIndex, int pageSize);

        //  void GetCoursesWithAuthors();
    }
}