namespace MKEWasteDisposal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedSchedule : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        ScheduleID = c.Int(nullable: false, identity: true),
                        Selection = c.String(),
                    })
                .PrimaryKey(t => t.ScheduleID);
            
            AddColumn("dbo.Customers", "ScheduleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "ScheduleId");
            AddForeignKey("dbo.Customers", "ScheduleId", "dbo.Schedules", "ScheduleID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "ScheduleId", "dbo.Schedules");
            DropIndex("dbo.Customers", new[] { "ScheduleId" });
            DropColumn("dbo.Customers", "ScheduleId");
            DropTable("dbo.Schedules");
        }
    }
}
