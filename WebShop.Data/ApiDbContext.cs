using Microsoft.EntityFrameworkCore;
using WebShop.Data.Configurations;
using WebShop.Models;

namespace WebShop.Data
{
	public class ApiDbContext : DbContext
	{
        public DbSet<Product> Products { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
		}
	}
}
