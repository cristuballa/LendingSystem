namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LedgerAddrowid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ledgers", "rowid", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ledgers", "rowid");
        }
    }
}
