namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        SubscriptionID = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 70),
                        UsersID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubscriptionID)
                .ForeignKey("dbo.Userss", t => t.UsersID, cascadeDelete: true)
                .Index(t => t.UsersID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subscriptions", "UsersID", "dbo.Userss");
            DropIndex("dbo.Subscriptions", new[] { "UsersID" });
            DropTable("dbo.Subscriptions");
        }
    }
}
