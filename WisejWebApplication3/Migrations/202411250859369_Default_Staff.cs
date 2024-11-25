namespace WisejWebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Default_Staff : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Staff", "Organization_Id", "dbo.Organization");
            DropIndex("dbo.Staff", new[] { "Organization_Id" });
            RenameColumn(table: "dbo.Staff", name: "Organization_Id", newName: "OrganizationId");
            AlterColumn("dbo.Staff", "OrganizationId", c => c.Int(nullable: false));
            CreateIndex("dbo.Staff", "OrganizationId");
            AddForeignKey("dbo.Staff", "OrganizationId", "dbo.Organization", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staff", "OrganizationId", "dbo.Organization");
            DropIndex("dbo.Staff", new[] { "OrganizationId" });
            AlterColumn("dbo.Staff", "OrganizationId", c => c.Int());
            RenameColumn(table: "dbo.Staff", name: "OrganizationId", newName: "Organization_Id");
            CreateIndex("dbo.Staff", "Organization_Id");
            AddForeignKey("dbo.Staff", "Organization_Id", "dbo.Organization", "Id");
        }
    }
}
