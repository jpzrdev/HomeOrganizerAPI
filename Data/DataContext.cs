
using HomeOrganizerAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ShopProduct> ShopProducts { get; set; }
        public DbSet<ShopList> ShopLists { get; set; }
        public DbSet<ShopListProduct> ShopListProducts { get; set; }
        public DbSet<ToDoTask> ToDoTasks { get; set; }
    }
}