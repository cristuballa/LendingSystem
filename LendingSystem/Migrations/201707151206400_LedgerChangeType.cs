namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LedgerChangeType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ledgers", "Credit", c => c.Double(nullable: false));
            AlterColumn("dbo.Ledgers", "Balance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ledgers", "Balance", c => c.Int(nullable: false));
            AlterColumn("dbo.Ledgers", "Credit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
