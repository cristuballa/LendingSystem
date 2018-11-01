using LendingSystem.Core.Repositories;
using System;
using System.Data.Entity.Infrastructure;

namespace LendingSystem.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBorrowerRepository Borrowers { get; }
        IOfficeRepository Offices { get; }
        ILoanRepository Loans { get; }
        ILoanPaymentRepository LoanPayments { get; }
        ILoanChargeRepository LoanCharges { get; }
        ILedgerRepository Ledgers { get; }
        int Complete();
        
    }
}