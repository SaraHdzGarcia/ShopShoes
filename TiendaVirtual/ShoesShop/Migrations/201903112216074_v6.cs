namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Userss", "LastName", c => c.String(maxLength: 20));
            AlterColumn("dbo.Userss", "FirstName", c => c.String(maxLength: 10));
            AlterColumn("dbo.Userss", "Address", c => c.String(maxLength: 60));
            AlterColumn("dbo.Userss", "ExtNumber", c => c.String(maxLength: 8));
            AlterColumn("dbo.Userss", "City", c => c.String(maxLength: 15));
            AlterColumn("dbo.Userss", "PostalCode", c => c.String(maxLength: 10));
            AlterColumn("dbo.Userss", "Country", c => c.String(maxLength: 15));
            AlterColumn("dbo.Userss", "Telephone", c => c.String(maxLength: 24));
            AlterColumn("dbo.Userss", "Email", c => c.String(maxLength: 70));
            AlterColumn("dbo.Userss", "UserName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Userss", "Password", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Userss", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Userss", "UserName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Userss", "Email", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Userss", "Telephone", c => c.String(nullable: false, maxLength: 24));
            AlterColumn("dbo.Userss", "Country", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Userss", "PostalCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Userss", "City", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Userss", "ExtNumber", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.Userss", "Address", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Userss", "FirstName", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Userss", "LastName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
