
using System;
using System.Collections.Generic;
using LendingSystem.Core.Domain;
namespace LendingSystem.Core.Repositories
{
    public interface ILoanPaymentRepository : IRepository<LoanPayment>
    {
       // IEnumerable<LoanPayment> GetBorrowersList();
        //  IEnumerable<Borrower> GetCoursesWithAuthors(int pageIndex, int pageSize);
        //  void GetCoursesWithAuthors();

        IEnumerable<LoanPayment> GetPayment(Int64 id);
        IEnumerable<LoanPayment> GetLedger(Int64 id);
        IEnumerable<LoanPayment> PaymentListByPeriod(DateTime DateFrom,DateTime DateTo);


    }
}
