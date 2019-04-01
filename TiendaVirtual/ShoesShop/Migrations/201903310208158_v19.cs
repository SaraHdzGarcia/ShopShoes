namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseDetail", "Payment", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PurchaseDetail", "Payment");
        }
    }
}
