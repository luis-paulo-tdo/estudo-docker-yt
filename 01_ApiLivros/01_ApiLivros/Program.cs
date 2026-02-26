using _01_ApiLivros.Endpoints;
using _01_ApiLivros.Extensions;
using _01_ApiLivros.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLivroContext();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

{
    var scope = app.Services.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<LivroContext>();
    dbContext.Database.EnsureCreated();
}

app.UseHttpsRedirection();

app.MapLivroEndpoints();

app.Run();

