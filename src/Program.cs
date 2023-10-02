using API.src.Graph;
using Microsoft.EntityFrameworkCore;
using src.Chefs;
using src.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql("Server=localhost;Port=5432;Database=epicure;;Username=postgres;Password=mysecretpassword"));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

builder.Services.AddScoped<ChefsRepository, ChefsRepository>();

var app = builder.Build();
// this is a new commit
app.MapGraphQL();

app.Run();
