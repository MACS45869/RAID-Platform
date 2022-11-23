
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Repositories.Context;
using RAIDPlatform.Data.Repositories.Interfaces;
using RAIDPlatform.Data.Repositories.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    //c.OrderActionsBy((apiDesc) => $"{apiDesc.ActionDescriptor.RouteValues["controller"]}_{apiDesc.RelativePath}");
});

//DatabaseConnection
//var connString = builder.Configuration.GetConnectionString("RAIDPlatform");
builder.Services.AddDbContext<MasterContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("RAIDPlatform")));
builder.Services.AddScoped<MasterContext>();
builder.Services.AddScoped<IMasterRepository, MasterRepository>();

builder.Services.AddDbContext<ClientContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("RAIDPlatform")));
builder.Services.AddScoped<ClientContext>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseHttpsRedirection();
app.UseAuthorization();
//For routing
app.UseMvc();
app.MapControllers();
app.Run();
