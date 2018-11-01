using LendingSystem.Core.Domain;
using LendingSystem.Persistence.EntityConfiguration;
using System.Data.Entity;

namespace LendingSystem.Persistence
{
    public class LendingContext : DbContext
    {
        public LendingContext()
            : base("name=LendingContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        //string connectionString = "Data Source=MyDataSource;User Id=sa;Password=sa;Initial Catalog=My_Db";
        //Configuration config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);
        //ConnectionStringsSection section = (ConnectionStringsSection)config.GetSection("connectionStrings");
        //            section.ConnectionStrings["SmartClient"].ConnectionString = connectionString;

        //config.Save();
        //this.Close();


        public virtual DbSet<Borrower> Borrowers { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Guarrantor> Guarrantors { get; set; }
        public virtual DbSet<LoanPayment> LoanPayments { get; set; }

        public virtual DbSet<LoanCharge> LoanCharges { get; set; }

        public virtual DbSet<Ledger> Ledgers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Configurations.Add(new BorrowerConfiguration());
            modelBuilder.Configurations.Add(new LoanConfiguration());

        }
    }
}
