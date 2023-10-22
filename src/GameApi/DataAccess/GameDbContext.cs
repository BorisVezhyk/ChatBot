using GameApi.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameApi.DataAccess;

public class GameDbContext : DbContext
{
	private readonly IConfiguration _configuration;

	public GameDbContext(IConfiguration configuration)
	{
		_configuration = configuration;
	}
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite(_configuration.GetConnectionString("GameDataBase"));
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Game>()
			.HasMany<Level>()
			.WithOne(x => x.Game)
			.HasForeignKey(x => x.GameId)
			.IsRequired();
		
		modelBuilder.Entity<Level>(level =>
		{
			level.HasMany<Answer>()
				.WithOne(x => x.Level)
				.HasForeignKey(x => x.LevelId)
				.IsRequired();
			level.HasMany<Hint>()
				.WithOne(x=>x.Level)
				.HasForeignKey(x=>x.LevelId)
				.IsRequired();
		});
	}

	public DbSet<Game> Games { get; set; }
	public DbSet<Level> Levels { get; set; }
	public DbSet<Hint> Hints { get; set; }
	public DbSet<Answer> Answers { get; set; }
}