namespace LendingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLedger : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ledgers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DatePost = c.DateTime(nullable: false),
                        TransType = c.Int(nullable: false),
                        Reference = c.String(),
                        Remark = c.String(),
                        Debit = c.Double(nullable: false),
                        Credit = c.Double(nullable: false),
                        Balance = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ledgers");
        }
    }
}
