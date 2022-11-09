
using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Repositories.Context;
using RAIDPlatform.Data.Repositories.Interfaces;
using RAIDPlatform.Data.Repositories.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

//DatabaseConnection
//var connString = builder.Configuration.GetConnectionString("RAIDPlatform");
builder.Services.AddDbContext<MasterContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("RAIDPlatform")));
builder.Services.AddControllers();
builder.Services.AddScoped<MasterContext>();
builder.Services.AddScoped<IMasterRepository, MasterRepository>();

builder.Services.AddDbContext<ClientContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("RAIDPlatform")));
builder.Services.AddScoped<ClientContext>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseAuthorization();
//For routing
app.UseMvc();
app.Run();
