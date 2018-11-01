namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LedgerChangeDebitToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ledgers", "Debit", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ledgers", "Debit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
