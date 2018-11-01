
using System.ComponentModel.DataAnnotations.Schema;
using LendingSystem.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace LendingSystem.Persistence.EntityConfiguration
{
    public class BorrowerConfiguration : EntityTypeConfiguration<Borrower>
    {
        public BorrowerConfiguration()
        {
           
            Property(c => c.FirstName).IsRequired().HasMaxLength(100);

            Property(c => c.LastName).IsRequired().HasMaxLength(100);

            Property(c => c.Address).IsRequired();

            Property(c => c.ContactInfo ).IsRequired();

            Property(c => c.Designation).IsRequired();

            Property(c => c.Gender).IsRequired();
 
            Property(c => c.OfficeId).HasColumnName("OfficeId");

            Property(c => c.BorrowerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasMany(c => c.Loans).WithRequired(c => c.Borrower)
                                 .HasForeignKey(c => c.BorrowerId)
                                 .WillCascadeOnDelete(false);


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