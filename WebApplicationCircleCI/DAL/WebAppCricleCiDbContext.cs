using Microsoft.EntityFrameworkCore;

namespace WebApplicationCircleCI.DAL
{
    public class WebAppCricleCiDbContext : DbContext
    {
        public WebAppCricleCiDbContext() : base()
        {
        }

        public WebAppCricleCiDbContext(DbContextOptions<WebAppCricleCiDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductsCategories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(table => new { table.ProductId, table.CategoryId });
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=WebAppCricleCi;Trusted_Connection=True;");
        //    }
        //}
    }
}