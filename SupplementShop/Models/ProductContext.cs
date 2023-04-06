using SupplementShop.Models;
using System.Data.Entity;
namespace SupplementShop.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("SupplementShop")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}