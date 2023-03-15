using Microsoft.EntityFrameworkCore;

namespace EF_Category_Product.Models
{
    public class CategoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EntityFramework_Categories_Products;Trusted_Connection=True");
        }
    }
}
