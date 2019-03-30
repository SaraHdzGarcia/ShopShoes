namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoppingCart", "Description", c => c.String(nullable: false, maxLength: 70));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShoppingCart", "Description");
        }
    }
}
