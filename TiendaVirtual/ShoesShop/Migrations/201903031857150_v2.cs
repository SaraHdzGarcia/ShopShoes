namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Products", "BarCode", c => c.String(nullable: false, maxLength: 12));
            DropColumn("dbo.Products", "ProducPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProducPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "BarCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 40));
            DropColumn("dbo.Products", "ProductPrice");
        }
    }
}
