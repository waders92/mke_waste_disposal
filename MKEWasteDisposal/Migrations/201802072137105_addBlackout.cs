namespace MKEWasteDisposal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBlackout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BlackOutStart", c => c.String());
            AddColumn("dbo.Customers", "BlackOutEnd", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BlackOutEnd");
            DropColumn("dbo.Customers", "BlackOutStart");
        }
    }
}
