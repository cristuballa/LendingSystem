

using LendingSystem.Core.Domain;
using LendingSystem.Core.Repositories;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace LendingSystem.Persistence.Repositories
{
    public class BorrowerRepository : Repository<Borrower>, IBorrowerRepository
    {
        public BorrowerRepository(LendingContext context)
            : base(context)
        {

        }

        public IEnumerable<Borrower> GetBorrowersList(string keyword)
        {

            return LendingContext.Borrowers.SqlQuery("BorrowerListGet @Keyword",
                new SqlParameter("Keyword", SqlDbType.Text ) { Value = keyword }).ToList();

        }


        //public IEnumerable<Borrower> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        //{
        //    //   return LendingContext.Courses
        //    //.Include(c => c.Author)
        //    //.OrderBy(c => c.Name)
        //    //.Skip((pageIndex - 1) * pageSize)
        //    //.Take(pageSize)
        //    //.ToList();
        //}


        public LendingContext LendingContext
        {
            get { return Context as LendingContext; }
        }
    }
}