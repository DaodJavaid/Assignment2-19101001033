using Microsoft.EntityFrameworkCore;
using Task4_19101001033.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<SignupDbContext>(op => 
    op.UseSqlServer(builder.Configuration.GetConnectionString("dbConnection") ??
    throw new InvalidOperationException("Connection string 'dbConnection' not found.")));


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
