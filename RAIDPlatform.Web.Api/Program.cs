
using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Repositories.Context;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

//DatabaseConnection
builder.Services.AddDbContext<MasterContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("RAIDPlatform")));
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.Run();
