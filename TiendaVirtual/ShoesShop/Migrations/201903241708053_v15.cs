namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v15 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.Orders", new[] { "EmployeeID" });
            RenameColumn(table: "dbo.Orders", name: "EmployeeID", newName: "Employees_EmployeeID");
            AlterColumn("dbo.Orders", "Employees_EmployeeID", c => c.Int());
            CreateIndex("dbo.Orders", "Employees_EmployeeID");
            AddForeignKey("dbo.Orders", "Employees_EmployeeID", "dbo.Employees", "EmployeeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Employees_EmployeeID", "dbo.Employees");
            DropIndex("dbo.Orders", new[] { "Employees_EmployeeID" });
            AlterColumn("dbo.Orders", "Employees_EmployeeID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Orders", name: "Employees_EmployeeID", newName: "EmployeeID");
            CreateIndex("dbo.Orders", "EmployeeID");
            AddForeignKey("dbo.Orders", "EmployeeID", "dbo.Employees", "EmployeeID", cascadeDelete: true);
        }
    }
}
