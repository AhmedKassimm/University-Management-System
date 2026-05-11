using Microsoft.EntityFrameworkCore;
using UniversityProject.Infrastructure.Data;

namespace UniversityProject.APIs.Middleware
{
    public static class ApplyMigrations
    {
        public static async Task ApplyMigration(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var servies = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            await servies.Database.MigrateAsync();
        }

    }
}
