namespace GameApi.DataAccess.Entities;

public class Level
{
	public long Id { get; set; }
	public long GameId { get; set; }
	public Game Game{ get; set; } = null!;
	public string? Name { get; set; }
	public string? Description { get; set; }
	public int OrderNumber { get; set; }
	public long TimeInSec { get; set; }
	public int? CountRightAnswers { get; set; }
	public DateTime? FinishDate { get; set; }
	public char? Status { get; set; }
	public ICollection<Hint>? Hints { get; set; }
	public ICollection<Answer>? Answers { get; set; }
}