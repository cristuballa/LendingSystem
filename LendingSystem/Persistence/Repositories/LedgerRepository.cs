using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using LendingSystem.Core.Domain;
using LendingSystem.Core.Repositories;

namespace LendingSystem.Persistence.Repositories
{
    public class LedgerRepository : Repository<Ledger> ,ILedgerRepository
    {

        public LedgerRepository(LendingContext context)
            : base(context)
        {

        }
        public IEnumerable<Ledger> GetLoanLedger(Int64 loanId)
        {

             var ledger= LendingContext.Ledgers.SqlQuery("LedgerGet @LoanId",
                  new SqlParameter("LoanId", SqlDbType.BigInt) {Value = loanId}).ToList();
            return ledger;

        }


        public LendingContext LendingContext
        {
            get { return Context as LendingContext; }
        }

    }
}
