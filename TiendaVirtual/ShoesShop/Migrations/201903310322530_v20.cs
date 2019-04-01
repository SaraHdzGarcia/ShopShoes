namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v20 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderTracking", "Status", c => c.String(maxLength: 50));
            DropColumn("dbo.OrderTracking", "Address");
            DropColumn("dbo.OrderTracking", "City");
            DropColumn("dbo.OrderTracking", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderTracking", "Country", c => c.String(maxLength: 15));
            AddColumn("dbo.OrderTracking", "City", c => c.String(maxLength: 15));
            AddColumn("dbo.OrderTracking", "Address", c => c.String(maxLength: 60));
            DropColumn("dbo.OrderTracking", "Status");
        }
    }
}
