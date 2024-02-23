using Microsoft.EntityFrameworkCore;
using WWDemo.Data.Configurations;
using WWDemo.Models;

namespace WWDemo.Data
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
