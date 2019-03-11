namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Userss", "Address", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Userss", "ExtNumber", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.Userss", "City", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Userss", "PostalCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Userss", "Country", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Userss", "Telephone", c => c.String(nullable: false, maxLength: 24));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Userss", "Telephone", c => c.String(maxLength: 24));
            AlterColumn("dbo.Userss", "Country", c => c.String(maxLength: 15));
            AlterColumn("dbo.Userss", "PostalCode", c => c.String(maxLength: 10));
            AlterColumn("dbo.Userss", "City", c => c.String(maxLength: 15));
            AlterColumn("dbo.Userss", "ExtNumber", c => c.String(maxLength: 8));
            AlterColumn("dbo.Userss", "Address", c => c.String(maxLength: 60));
        }
    }
}
