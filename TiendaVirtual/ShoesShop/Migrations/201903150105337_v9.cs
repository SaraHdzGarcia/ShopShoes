namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Subscriptions", "UsersID", "dbo.Userss");
            DropIndex("dbo.Subscriptions", new[] { "UsersID" });
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 60),
                        Email = c.String(maxLength: 70),
                        Telephone = c.String(maxLength: 24),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ContactID);
            
            DropTable("dbo.Subscriptions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        SubscriptionID = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 70),
                        UsersID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubscriptionID);
            
            DropTable("dbo.Contact");
            CreateIndex("dbo.Subscriptions", "UsersID");
            AddForeignKey("dbo.Subscriptions", "UsersID", "dbo.Userss", "UserID", cascadeDelete: true);
        }
    }
}
