namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 30),
                        Description = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        CategoryID = c.Int(nullable: false),
                        UnitsInStock = c.Short(nullable: false),
                        ProducPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Short(nullable: false),
                        Color = c.String(maxLength: 30),
                        Size = c.String(maxLength: 15),
                        BarCode = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Short(nullable: false),
                        Color = c.String(maxLength: 30),
                        Size = c.String(maxLength: 15),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        ShippedDate = c.DateTime(nullable: false),
                        TotalProduct = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Userss", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 10),
                        Address = c.String(maxLength: 60),
                        City = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        Country = c.String(maxLength: 15),
                        Telephone = c.String(maxLength: 24),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Userss", t => t.UserID, cascadeDelete: false)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Shop",
                c => new
                    {
                        ShopID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Address = c.String(maxLength: 60),
                        City = c.String(maxLength: 15),
                        Country = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        OrderID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShopID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: false)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.EmployeeID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Userss",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 10),
                        Address = c.String(maxLength: 60),
                        ExtNumber = c.String(maxLength: 8),
                        City = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        Country = c.String(maxLength: 15),
                        Telephone = c.String(maxLength: 24),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.ShoppingCart",
                c => new
                    {
                        ShoppingCartID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ShoppingCartID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Userss", t => t.UserID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.OrderTracking",
                c => new
                    {
                        OrderTrackingID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        Address = c.String(maxLength: 60),
                        City = c.String(maxLength: 15),
                        Country = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.OrderTrackingID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "UserID", "dbo.Userss");
            DropForeignKey("dbo.OrderTracking", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Employees", "UserID", "dbo.Userss");
            DropForeignKey("dbo.ShoppingCart", "UserID", "dbo.Userss");
            DropForeignKey("dbo.ShoppingCart", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Shop", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Shop", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Shop", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.OrderTracking", new[] { "OrderID" });
            DropIndex("dbo.ShoppingCart", new[] { "UserID" });
            DropIndex("dbo.ShoppingCart", new[] { "ProductID" });
            DropIndex("dbo.Shop", new[] { "ProductID" });
            DropIndex("dbo.Shop", new[] { "EmployeeID" });
            DropIndex("dbo.Shop", new[] { "OrderID" });
            DropIndex("dbo.Employees", new[] { "UserID" });
            DropIndex("dbo.Orders", new[] { "EmployeeID" });
            DropIndex("dbo.Orders", new[] { "UserID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropTable("dbo.OrderTracking");
            DropTable("dbo.ShoppingCart");
            DropTable("dbo.Userss");
            DropTable("dbo.Shop");
            DropTable("dbo.Employees");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
