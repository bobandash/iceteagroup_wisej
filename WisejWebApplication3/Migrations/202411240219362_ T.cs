namespace WisejWebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class T : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Organizations", newName: "Organization");
            RenameTable(name: "dbo.Staffs", newName: "Staff");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Staff", newName: "Staffs");
            RenameTable(name: "dbo.Organization", newName: "Organizations");
        }
    }
}
