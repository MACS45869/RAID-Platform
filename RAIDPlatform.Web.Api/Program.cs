using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Repositories.Context;
using RAIDPlatform.Data.Repositories.Interfaces;
using RAIDPlatform.Data.Repositories.Repositories;
using RAIDPlatform.Services.ClientService;
using RAIDPlatform.Services.MasterService;

var builder = WebApplication.CreateBuilder(args);


builder.WebHost.UseUrls("http://0.0.0.0:5001");
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    //c.OrderActionsBy((apiDesc) => $"{apiDesc.ActionDescriptor.RouteValues["controller"]}_{apiDesc.RelativePath}");
});

//DatabaseConnection
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
builder.Services.AddScoped<IMasterService, MasterService>();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
var app = builder.Build();


// Configure the HTTP request pipeline.
if(builder.Configuration.GetValue<string>("Swagger") == "on") {
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty;
    });
}

//app.UseHttpsRedirection();
app.UseAuthorization();
//For routing
app.UseMvc();
app.MapControllers();
app.Run();
