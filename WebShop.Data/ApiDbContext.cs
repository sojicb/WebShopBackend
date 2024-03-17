using Microsoft.EntityFrameworkCore;
using WebShop.Data.Configurations;
using WebShop.Models;

namespace WebShop.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);

            modelBuilder.Entity<Category>()
                .HasMany(x => x.Products);

            modelBuilder.Entity<Product>()
                 .HasMany(x => x.Tags);

            modelBuilder.Entity<Tag>()
                .HasMany(x => x.Products);

            modelBuilder.Entity<Product>()
				.ToTable(nameof(Product));

			modelBuilder.Entity<Category>()
				.ToTable(nameof(Category));

			modelBuilder.Entity<Tag>()
				.ToTable(nameof(Tag));
		}
    }
}
