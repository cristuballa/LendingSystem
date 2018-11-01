
using System;
using System.Collections.Generic;
using System.Linq;
using LendingSystem.Core.Domain;

namespace LendingSystem.Core.Repositories
{
    public interface ILoanRepository : IRepository<Loan>
    {
        IEnumerable<Loan> GetBorrowerLoanList(Int64  id);
        IEnumerable<Loan> GetLoanWithBorrower(Int64 loanId);

       // object Find(long id);
    }
}
