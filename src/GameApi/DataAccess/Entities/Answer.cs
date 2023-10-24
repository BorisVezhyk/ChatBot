using System.ComponentModel.DataAnnotations.Schema;

namespace GameApi.DataAccess.Entities;

public class Answer
{
	public long Id { get; set; }
	[ForeignKey(nameof(LevelId))]
	public long? LevelId { get; set; }
	public string Value { get; set; } = null!;
	public int BonusInSec { get; set; }
	public char Status { get; set; }
	public char IsMain { get; set; }
}