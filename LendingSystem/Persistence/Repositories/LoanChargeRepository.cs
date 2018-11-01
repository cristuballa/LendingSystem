using System;

using LendingSystem.Core.Domain;
using LendingSystem.Core.Repositories;

namespace LendingSystem.Persistence.Repositories
{
    public class LoanChargeRepository : Repository<LoanCharge>, ILoanChargeRepository
    {
        public LoanChargeRepository(LendingContext context)
            : base(context)
        {

        }

    }
}
