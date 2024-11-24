namespace WisejWebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Zip_Field : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Organizations", "Zip", c => c.String());
            AddColumn("dbo.Organizations", "CountryCode", c => c.String());
            DropColumn("dbo.Organizations", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Organizations", "Country", c => c.String());
            DropColumn("dbo.Organizations", "CountryCode");
            DropColumn("dbo.Organizations", "Zip");
        }
    }
}
