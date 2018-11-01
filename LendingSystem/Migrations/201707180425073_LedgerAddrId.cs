namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LedgerAddrId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ledgers", "rId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ledgers", "rId");
        }
    }
}
