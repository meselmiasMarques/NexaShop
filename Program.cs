using Microsoft.OpenApi;
using NexaShop.Dtos.Categories;
using NexaShop.EndPoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "NexaShop API",
        Version = "v1",
        Description = "API para gerenciamento do e-commerce NexaShop"
    });
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "NexaShop API v1");
        options.RoutePrefix = "swagger";
    });
}


//Endpoints
app.MapCategory();


app.Run();
