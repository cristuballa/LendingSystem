using System;
using LendingSystem.Core.Domain;
using System.Collections.Generic;


namespace LendingSystem.Core.Repositories
{
    public interface IBorrowerRepository : IRepository<Borrower>
    {
        IEnumerable<Borrower> GetBorrowersList(string keyword);
       
      //  IEnumerable<Borrower> GetCoursesWithAuthors(int pageIndex, int pageSize);
      //  void GetCoursesWithAuthors();

    }
}