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
			.IsRequired();
		
		modelBuilder.Entity<Level>(level =>
		{
			level.HasMany<Answer>()
				.WithOne()
				.HasForeignKey(x => x.LevelId)
				.IsRequired(false);

			level.HasMany<Hint>()
				.WithOne()
				.HasForeignKey(x=> x.LevelId)
				.IsRequired(false);
		});
	}

	public DbSet<Game> Games { get; set; }
	public DbSet<Level> Levels { get; set; }
	public DbSet<Hint> Hints { get; set; }
	public DbSet<Answer> Answers { get; set; }
}