namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoppingCart", "BarCode", c => c.String(nullable: false, maxLength: 12));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ShoppingCart", "BarCode");
        }
    }
}
