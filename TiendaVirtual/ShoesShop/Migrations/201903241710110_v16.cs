namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v16 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Employees_EmployeeID", "dbo.Employees");
            DropIndex("dbo.Orders", new[] { "Employees_EmployeeID" });
            DropColumn("dbo.Orders", "Employees_EmployeeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Employees_EmployeeID", c => c.Int());
            CreateIndex("dbo.Orders", "Employees_EmployeeID");
            AddForeignKey("dbo.Orders", "Employees_EmployeeID", "dbo.Employees", "EmployeeID");
        }
    }
}
