namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v18 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseDetail",
                c => new
                    {
                        PurchaseDetailID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 10),
                        Address = c.String(nullable: false, maxLength: 60),
                        State = c.String(nullable: false, maxLength: 15),
                        Country = c.String(nullable: false, maxLength: 15),
                        PostalCode = c.String(nullable: false, maxLength: 10),
                        Telephone = c.String(nullable: false, maxLength: 24),
                        Email = c.String(nullable: false, maxLength: 70),
                        MothersLastName = c.String(maxLength: 70),
                    })
                .PrimaryKey(t => t.PurchaseDetailID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PurchaseDetail");
        }
    }
}
