
using HospitalManagementSystem.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var builder = WebApplication.CreateBuilder(args);

            //// Database
            ////builder.Services.AddDbContext<HospitalDbContext>(options =>
            ////    options.UseSqlServer(
            ////        builder.Configuration.GetConnectionString("DefaultConnection")));

            //// Identity
            //builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            //{
            //    options.Password.RequireDigit = true;
            //    options.Password.RequireUppercase = true;
            //    options.Password.RequireLowercase = true;
            //    options.Password.RequiredLength = 6;
            //})
            //.AddEntityFrameworkStores<HospitalDbContext>()
            //.AddDefaultTokenProviders();

            //// MVC
            //builder.Services.AddControllersWithViews();

            //var app = builder.Build();

            //// Configure Pipeline
            //if (!app.Environment.IsDevelopment())
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();

            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthentication();
            //app.UseAuthorization();

            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");

            //app.Run();
          

            var builder = WebApplication.CreateBuilder(args);

            // Database
            builder.Services.AddDbContext<HospitalDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")));

            // Identity
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredLength = 6;
            })
            .AddEntityFrameworkStores<HospitalDbContext>()
            .AddDefaultTokenProviders();

            // MVC
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure pipeline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}