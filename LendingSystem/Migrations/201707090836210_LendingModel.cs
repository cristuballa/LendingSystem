namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LendingModel : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.Borrowers",
                c => new
                    {
                        BorrowerId = c.Long(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        ContactInfo = c.String(nullable: false),
                        Designation = c.String(nullable: false),
                        MonthlyIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Balance = c.Single(nullable: false),
                        Status = c.Boolean(nullable: false),
                        OfficeId = c.Int(nullable: false),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.BorrowerId)
                .ForeignKey("dbo.Offices", t => t.OfficeId, cascadeDelete: true)
                .Index(t => t.OfficeId);
            
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        LoanId = c.Long(nullable: false, identity: true),
                        LoanAmount = c.Single(nullable: false),
                        DateStart = c.DateTime(nullable: false),
                        TermsOfPayment = c.Single(nullable: false),
                        InterestRate = c.Single(nullable: false),
                        CalendarRate = c.Int(nullable: false),
                        Restructure = c.Int(nullable: false),
                        Remark = c.String(),
                        Reference = c.String(),
                        BorrowerId = c.Long(nullable: false),
                        Balance = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.LoanId)
                .ForeignKey("dbo.Borrowers", t => t.BorrowerId)
                .Index(t => t.BorrowerId);
            
            CreateTable(
                "dbo.Guarrantors",
                c => new
                    {
                        GuarrantorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        ContactInfo = c.String(),
                        LoanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.GuarrantorId)
                .ForeignKey("dbo.Loans", t => t.LoanId)
                .Index(t => t.LoanId);
            
            CreateTable(
                "dbo.LoanCharges",
                c => new
                    {
                        LoanChargeId = c.Long(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remark = c.String(),
                        Refernce = c.String(),
                        LoanId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.LoanChargeId)
                .ForeignKey("dbo.Loans", t => t.LoanId)
                .Index(t => t.LoanId);
            
            CreateTable(
                "dbo.LoanPayments",
                c => new
                    {
                        LoanPaymentId = c.Long(nullable: false, identity: true),
                        DatePost = c.DateTime(nullable: false),
                        AmountPaid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentType = c.Int(nullable: false),
                        LoanId = c.Long(nullable: false),
                        Remark = c.String(),
                        Reference = c.String(),
                    })
                .PrimaryKey(t => t.LoanPaymentId)
                .ForeignKey("dbo.Loans", t => t.LoanId)
                .Index(t => t.LoanId);
            
            CreateTable(
                "dbo.Offices",
                c => new
                    {
                        OfficeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OfficeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Borrowers", "OfficeId", "dbo.Offices");
            DropForeignKey("dbo.Loans", "BorrowerId", "dbo.Borrowers");
            DropForeignKey("dbo.LoanPayments", "LoanId", "dbo.Loans");
            DropForeignKey("dbo.LoanCharges", "LoanId", "dbo.Loans");
            DropForeignKey("dbo.Guarrantors", "LoanId", "dbo.Loans");
            DropIndex("dbo.LoanPayments", new[] { "LoanId" });
            DropIndex("dbo.LoanCharges", new[] { "LoanId" });
            DropIndex("dbo.Guarrantors", new[] { "LoanId" });
            DropIndex("dbo.Loans", new[] { "BorrowerId" });
            DropIndex("dbo.Borrowers", new[] { "OfficeId" });
            DropTable("dbo.Offices");
            DropTable("dbo.LoanPayments");
            DropTable("dbo.LoanCharges");
            DropTable("dbo.Guarrantors");
            DropTable("dbo.Loans");
            DropTable("dbo.Borrowers");
        }
    }
}
