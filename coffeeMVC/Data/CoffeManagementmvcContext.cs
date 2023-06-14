using coffeeMVC.Models;
using coffeeMVC.ViewModels;
using Microsoft.EntityFrameworkCore;
namespace coffeeMVC.Data
{
    public class CoffeManagementmvcContext : DbContext
    {
        public CoffeManagementmvcContext(DbContextOptions<CoffeManagementmvcContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Drink> Drink { get; set; }

        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<CartViewModel> CartViewModel { get; set; }
       

    }
}

        


