using System.ComponentModel.DataAnnotations;

namespace GameApi.Web.Models;

/// <summary>
/// The game request for create or updated existing game.
/// </summary>
public class GameRequest : IValidatableObject
{
	/// <summary>
	/// The name of game.
	/// </summary>
	[Required(ErrorMessage = "Name is required.")]
	public string Name { get; set; }= string.Empty;

	/// <summary>
	/// The start date of game.
	/// </summary>
	[Required(ErrorMessage = "StartDate is required.")]
	[DataType(DataType.Date)]
	public DateTime StartDate { get; set; }

	/// <summary>
	/// The description.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// The finish date.
	/// </summary>
	[DataType(DataType.Date)]
	public DateTime? FinishDate { get; set; }

	///<inheritdoc/>
	public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
	{
		if (StartDate<=DateTime.Now)
		{
			yield return new ValidationResult($"{nameof(StartDate)} can't be in the past.");
		}

		if (FinishDate != DateTime.MinValue && FinishDate <= StartDate)
		{
			yield return new ValidationResult($"{nameof(StartDate)} must be less than {nameof(FinishDate)}");
		}
	}
}