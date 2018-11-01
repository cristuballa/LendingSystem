namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LedgerChangeBalanceToInt32 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ledgers", "Balance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ledgers", "Balance", c => c.Double(nullable: false));
        }
    }
}
