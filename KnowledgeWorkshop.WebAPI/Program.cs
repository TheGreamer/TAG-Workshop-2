using KnowledgeWorkshop.WebAPI.Core.WebAPI.Concrete.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer()
                .AddSwaggerGen()
                .ConfigureMsSqlServer(builder.Configuration.GetConnectionString("MsSqlConnectionString"))
                .ConfigureServices()
                .AddCors(p => p.AddPolicy("corsapp", builder =>
                {
                    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
                }));

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseSwagger().UseSwaggerUI();

app.UseCors("corsapp")
   .UseHttpsRedirection()
   .UseAuthorization();
app.MapControllers();
app.Run();