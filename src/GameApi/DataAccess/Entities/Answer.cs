namespace GameApi.DataAccess.Entities;

public class Answer
{
	public long Id { get; set; }
	public long LevelId { get; set; }
	public string Value { get; set; } = null!;
	public int BonusInSec { get; set; }
	public Level Level { get; set; } = null!;
}