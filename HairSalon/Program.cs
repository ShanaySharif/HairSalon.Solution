using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using HairSalon.Models;

namespace HairSalon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<HairSalonContext>(
                dbContextOptions => dbContextOptions.UseMySql(
                    builder.Configuration["ConnectionStrings:DefaultConnection"],
                    ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"])
                )
            );
            WebApplication app = builder.Build();

            // app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );
            app.Run();
        }
    }
}