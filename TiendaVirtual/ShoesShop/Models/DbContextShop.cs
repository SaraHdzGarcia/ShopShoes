using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class DbContextShop: DbContext
    {
        public DbContextShop() : base("DbContextShop")
        {

        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderTracking> OrderTrackings { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Userss> Usersses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Subscriptions> Subscriptions { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//Le quita lo plural a la tabla.
        }
    }
}