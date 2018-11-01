
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using LendingSystem.Core.Domain;
using LendingSystem.Core.Repositories;


namespace LendingSystem.Persistence.Repositories
{
    public class LoanRepository:Repository<Loan>, ILoanRepository
    {
        public LoanRepository(LendingContext context)
            : base(context)
        {

        }

        public IEnumerable<Loan> GetBorrowerLoanList(Int64  id)
        {
            return LendingContext.Loans.SqlQuery(
                "LoanListGet @LoanId",
                new SqlParameter("LoanId", SqlDbType.BigInt) { Value = id }
            ).ToList();
        }


        public IEnumerable<Loan> GetLoanWithBorrower(Int64 loanId)
        {
          return (from loan in LendingContext.Loans.Include("Borrower")
                where loan.BorrowerId == loanId
                orderby loan.DateStart
                select loan).ToList();
        }
      
        public LendingContext LendingContext
        {
            get { return Context as LendingContext; }
        }
    }
}
