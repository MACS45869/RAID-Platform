
using FluentAssertions.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Repositories.Context;
using RAIDPlatform.Data.Repositories.Interfaces;
using RAIDPlatform.Data.Repositories.Repositories;
using RAIDPlatform.Services.ClientService;

var builder = WebApplication.CreateBuilder(args);

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

//Services
builder.Services.AddScoped<IClientService, ClientService>();
//builder.Services.AddScoped<IMasterService, MasterService>();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
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
