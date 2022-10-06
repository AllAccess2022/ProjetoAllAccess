using Microsoft.EntityFrameworkCore;
using ProjetoAllAccess.Data;
using ProjetoAllAccess.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Contexto>(options =>
    options.UseMySql("Server=localhost;Port=3306;Database=allaccessdb;Uid=root;Pwd=allaccess;",
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql")));
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
