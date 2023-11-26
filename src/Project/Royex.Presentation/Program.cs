using Mapster;
using Microsoft.EntityFrameworkCore;
using Royex.Persistance.Context;
using Royex.Presentation.Service_Extension;

var builder = WebApplication.CreateBuilder(args);

//ConnectionString
var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");

// Add services to the container.
builder.Services.AddControllersWithViews();

//Dependency Serive Configuration
builder.Services.DependencyServiceConfiguration();

//Database Configuration
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(connectionString, actiion =>
    actiion.MigrationsAssembly(typeof(Royex.Presentation.PresentationAssemblyReference).Assembly.FullName));
});

//MediatR package Configuration
builder.Services.AddMediatR(x =>
x.RegisterServicesFromAssembly(typeof(Royex.Application.ApplicationAssemblyReferene).Assembly));

//Adding Mapster
builder.Services.AddMapster();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
