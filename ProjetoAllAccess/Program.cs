using Microsoft.EntityFrameworkCore;
using ProjetoAllAccess.Data;
using ProjetoAllAccess.Helper;
using ProjetoAllAccess.Repositorio;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<Contexto>(options =>
            options.UseMySql("Server=localhost;Port=3306;Database=allaccessdb;Uid=root;Pwd=allaccess;",
            ServerVersion.Parse("8.0.30-mysql")));
        builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
        builder.Services.AddScoped<ISessao, Sessao>();
        builder.Services.AddScoped<IEmail, Email>();

        builder.Services.AddSession(o => 
        {
            o.Cookie.HttpOnly= true;
            o.Cookie.IsEssential= true;
        }
        );
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseSession();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Login}/{action=Index}/{id?}");

        app.Run();
    }
}