namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoanChargeModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoanCharges", "DatePost", c => c.DateTime(nullable: false));
            AddColumn("dbo.LoanCharges", "Reference", c => c.String());
            AlterColumn("dbo.LoanCharges", "Amount", c => c.Single(nullable: false));
            DropColumn("dbo.LoanCharges", "Refernce");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LoanCharges", "Refernce", c => c.String());
            AlterColumn("dbo.LoanCharges", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.LoanCharges", "Reference");
            DropColumn("dbo.LoanCharges", "DatePost");
        }
    }
}
