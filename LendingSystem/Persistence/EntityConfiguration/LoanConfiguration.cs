
using System.ComponentModel.DataAnnotations.Schema;
using LendingSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace LendingSystem.Persistence.EntityConfiguration
{
    public class LoanConfiguration : EntityTypeConfiguration<Loan>
    {
        public LoanConfiguration()
        {
            Property(c => c.LoanAmount)
                .IsRequired();

            HasKey(c => c.LoanId);

            HasMany(c => c.Guarrantors)
                .WithRequired(c => c.Loan)
                .HasForeignKey(c => c.LoanId)
                .WillCascadeOnDelete(false); 

            HasMany(c => c.LoanPayments )
                .WithRequired(c => c.Loan)
                .HasForeignKey(c => c.LoanId)
                .WillCascadeOnDelete(false);

            HasMany(c => c.LoanCharges )
                .WithRequired(c => c.Loan)
                .HasForeignKey(c => c.LoanId)
                .WillCascadeOnDelete(false);

            Property(c => c.LoanId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
              
            //HasRequired(c => c.Office)
            //    .WithMany(a => a.Borrower)
            //    .HasForeignKey(c => c.OfficeId)
            //    .WillCascadeOnDelete(false);

            //HasRequired(c => c.Cover)
            //    .WithRequiredPrincipal(c => c.Course);

            //HasMany(c => c.Tags)
            //    .WithMany(t => t.Courses)
            //    .Map(m =>
            //    {
            //        m.ToTable("CourseTags");
            //        m.MapLeftKey("CourseId");
            //        m.MapRightKey("TagId");
            //    });


        }
    }
}