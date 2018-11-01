
using System;
using System.Collections.Generic;
using LendingSystem.Core.Domain;

namespace LendingSystem.Core.Repositories
{
   public interface ILedgerRepository: IRepository<Ledger>
    {
       IEnumerable<Ledger> GetLoanLedger(Int64 ledgerId);
    }
}
