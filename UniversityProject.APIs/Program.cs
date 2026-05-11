
using Microsoft.EntityFrameworkCore;
using UniversityProject.APIs.Middleware;
using UniversityProject.Domin.Abstraction;
using UniversityProject.Infrastructure;
using UniversityProject.Infrastructure.Data;
using UniversityProject.Service;

namespace UniversityProject.APIs
{
    public class Program
    {
        public static async Task Main()
        {
            var builder = WebApplication.CreateBuilder();


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.ApplyInfrastructureDependencies().ApplySerivecsDependencies();
            var app = builder.Build();
           

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
               await app.ApplyMigration();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
