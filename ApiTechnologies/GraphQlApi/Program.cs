using GraphQlApi.Queries;
using GraphQlApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IBookService, BookService>();

builder.Services
       .AddGraphQLServer()
       .AddQueryType<Query>()
       .AddMutationType<Mutations>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
