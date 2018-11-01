namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LedgerChangeCreditToDecimal2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ledgers", "Balance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ledgers", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
