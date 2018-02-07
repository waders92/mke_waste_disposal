namespace MKEWasteDisposal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamecolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schedules", "PickUpFrequency", c => c.String());
            DropColumn("dbo.Schedules", "Selection");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schedules", "Selection", c => c.String());
            DropColumn("dbo.Schedules", "PickUpFrequency");
        }
    }
}
