using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ChatBotTelegram.DataAccess;

public class GameDbContext : DbContext
{
	private readonly IConfiguration _configuration;

	public GameDbContext(IConfiguration configuration)
	{
		_configuration = configuration;
	}
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);
		optionsBuilder.UseSqlite(@"DataSource=.\DataAccess\DataBase\games.db");
	}
}