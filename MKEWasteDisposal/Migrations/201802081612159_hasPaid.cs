namespace MKEWasteDisposal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hasPaid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "hasPaid", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "hasPaid");
        }
    }
}
