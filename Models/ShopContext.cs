using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace dotnet_sandbox.Models
{
    public class ShopContext : DbContext
    {
      public ShopContext(DbContextOptions<ShopContext> options) : base(options)
      {
      }

      public DbSet<Product> Products { get; set; }
      public DbSet<Category> Categories { get; set; }
      
    }
}