using FirstWebApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddDbContextPool<FirstWebAppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FirstWebAppDb"));
});

builder.Services.AddScoped<IRestaurantData, SqlRestaurantData>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(e =>
{
    e.MapControllers();
});

// app.MapControllerRoute(name:"Restaurants", pattern: "{controller}/{action}/{id?}");

app.UseAuthorization();

app.MapRazorPages();

app.Run();