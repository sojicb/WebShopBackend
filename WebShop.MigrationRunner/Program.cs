using Microsoft.EntityFrameworkCore;
using WebShop.MigrationRunner;

using var context = new ApiDbContextFactory().CreateDbContext(args);

context.Database.Migrate();
