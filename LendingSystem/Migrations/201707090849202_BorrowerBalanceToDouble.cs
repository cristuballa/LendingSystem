namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BorrowerBalanceToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Borrowers", "Balance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Borrowers", "Balance", c => c.Single(nullable: false));
        }
    }
}
