namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LedgerChangeCreditToDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ledgers", "Debit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Ledgers", "Credit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Ledgers", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ledgers", "Balance", c => c.Double(nullable: false));
            AlterColumn("dbo.Ledgers", "Credit", c => c.Double(nullable: false));
            AlterColumn("dbo.Ledgers", "Debit", c => c.Double(nullable: false));
        }
    }
}
