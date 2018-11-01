namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoanBalanceChangeToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Loans", "Balance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Loans", "Balance", c => c.Single(nullable: false));
        }
    }
}
