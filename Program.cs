using Chamados.Data;
using Chamados.repositorio;
using Microsoft.EntityFrameworkCore;
using System;

namespace Chamados
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<Contexto>
             (options => options.UseSqlServer
             ("Data Source=DESKTOP-9OM2BHU\\SQLEXPRESS;Initial Catalog=ChamadoMaster;Integrated Security=False;User ID=sa;Password=123; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = False" ));
             
            builder.Services.AddScoped<IChamadoRepositorio,ChamadoRepositorio >();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}