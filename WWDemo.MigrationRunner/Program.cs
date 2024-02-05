using Microsoft.EntityFrameworkCore;
using WWDemo.MigrationRunner;

using var context = new ApiDbContextFactory().CreateDbContext(args);

context.Database.Migrate();
