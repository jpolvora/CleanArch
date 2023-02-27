using CleanArch.Data.Authentication;
using CleanArch.Data.Shared;
using CleanArch.Domain.Auth;
using CleanArch.Infra;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IHttpPostClient<>), typeof(HttpClient<>));
builder.Services.AddScoped<IAuthentication, RemoteAuthentication>();
builder.Services.AddScoped<AuthenticationUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
