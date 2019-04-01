namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderTracking", "Statuss", c => c.String(maxLength: 50));
            DropColumn("dbo.OrderTracking", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderTracking", "Status", c => c.String(maxLength: 50));
            DropColumn("dbo.OrderTracking", "Statuss");
        }
    }
}
