using System.Configuration;
using System;
using DBIntegration.Db.Context;
using Microsoft.EntityFrameworkCore;
using DBIntegration.Service.Services;

namespace DBIntegration.web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            builder.Services.AddDbContext<ProductDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddTransient<IProductService, ProductService>();

            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapControllers();

            app.MapRazorPages();

            app.Run();
        }
    }
}
