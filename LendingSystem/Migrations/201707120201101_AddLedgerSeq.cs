namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLedgerSeq : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ledgers", "Seq", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ledgers", "Seq");
        }
    }
}
