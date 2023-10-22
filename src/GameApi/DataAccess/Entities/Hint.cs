using System.ComponentModel.DataAnnotations.Schema;

namespace GameApi.DataAccess.Entities;

public class Hint
{
	public long Id { get; set; }
	[ForeignKey(nameof(LevelId))]
	public long? LevelId { get; set; }
	public string? HintText { get; set; }
	public int OrderNumber { get; set; }
	public int TimeInSec { get; set; }
}