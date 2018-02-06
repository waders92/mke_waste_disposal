namespace MKEWasteDisposal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserIdTOCustomer : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "User_Id", newName: "UserID");
            RenameIndex(table: "dbo.Customers", name: "IX_User_Id", newName: "IX_UserID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Customers", name: "IX_UserID", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Customers", name: "UserID", newName: "User_Id");
        }
    }
}
