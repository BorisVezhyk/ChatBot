using GameApi.DataAccess;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
IServiceCollection services = builder.Services;

// Add services to the container.
//DataBase
services.AddDbContext<GameDbContext>();
services.AddScoped<IDataAccessService, DataAccessService>();

services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

WebApplication app = builder.Build();

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
