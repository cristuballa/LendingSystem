using System.Data.Entity.Infrastructure;
using System.Runtime.Remoting.Contexts;
using LendingSystem.Core;
using LendingSystem.Core.Repositories;
using LendingSystem.Persistence.Repositories;

namespace LendingSystem.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LendingContext _context;


        public UnitOfWork(LendingContext context)
        {

             _context = context;
             Borrowers = new BorrowerRepository(_context);
             Offices = new OfficeRepository(_context);
             Loans = new LoanRepository(_context);
             LoanPayments = new LoanPaymentRepository(_context);
             LoanCharges = new LoanChargeRepository(_context);
             Ledgers = new LedgerRepository(_context);

        }


        public IBorrowerRepository Borrowers { get; private set; }
        public IOfficeRepository Offices { get; private set; }
        public ILoanRepository Loans  { get; private set; }
        public ILoanPaymentRepository LoanPayments { get; private set; }
        public ILoanChargeRepository LoanCharges { get; private set; }

        public ILedgerRepository Ledgers { get;  set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}