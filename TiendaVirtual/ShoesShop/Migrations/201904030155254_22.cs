namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseDetail", "Shipping", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PurchaseDetail", "Shipping");
        }
    }
}
