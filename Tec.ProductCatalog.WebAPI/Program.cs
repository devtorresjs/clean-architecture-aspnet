using HttpExceptionHandling;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

/* se registran los servicios de HttpExceptionHandler ************/
builder.Services.AddHttpFallbackExceptionHandler();
builder.Services.AddHttpDomainValidationExceptionHandler();
/**************************************************************/

builder.Services.AddTecProductCalogServices(
    dbOptions => builder.Configuration
    .GetRequiredSection(ProductCatalogDbOptions.SectionKey)
    .Bind(dbOptions));

var app = builder.Build();

app.UseExceptionHandlerWithFallbackExceptionHandling();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseTecProductCatalogEndpoints();

app.Run();
