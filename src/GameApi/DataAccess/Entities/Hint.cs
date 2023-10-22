namespace GameApi.DataAccess.Entities;

public class Hint
{
	public long Id { get; set; }
	public long? LevelId { get; set; }
	public string? HintText { get; set; }
	public int OrderNumber { get; set; }
	public int TimeInSec { get; set; }
}