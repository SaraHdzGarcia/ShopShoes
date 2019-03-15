namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        SubscriptionID = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 70),
                    })
                .PrimaryKey(t => t.SubscriptionID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subscriptions");
        }
    }
}
