using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using LendingSystem.Core.Domain;
using LendingSystem.Core.Repositories;

namespace LendingSystem.Persistence.Repositories
{
    public class LoanPaymentRepository : Repository<LoanPayment>, ILoanPaymentRepository
    {
        public LoanPaymentRepository(LendingContext context)
            : base(context)
        {

        }
        public IEnumerable<LoanPayment> GetPayment(Int64 id)
        {
            return (from p in LendingContext.LoanPayments.Include("Loan")
                where p.LoanId  == id
                orderby p.DatePost
                select p).ToList();
        }

        public IEnumerable<LoanPayment> GetLedger(Int64 id)
        {
            return LendingContext.LoanPayments.SqlQuery(
                "PaymentListGet @LoanId",
                new SqlParameter("LoanId", SqlDbType.BigInt) { Value = id }
            ).ToList();

        }

        public IEnumerable<LoanPayment> PaymentListByPeriod(DateTime DateFrom, DateTime DateTo)
        {
            return LendingContext.LoanPayments.SqlQuery(
                "PaymentListGetByPeriod @DateFrom,@DateTo",
                new SqlParameter("DateFrom", SqlDbType.DateTime) { Value = DateFrom },
                new SqlParameter("DateTo", SqlDbType.DateTime) { Value = DateTo }

            ).ToList();

        }

        public LendingContext LendingContext
        {
            get { return Context as LendingContext; }
        }

    }
}
