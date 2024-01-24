using System.ComponentModel.DataAnnotations;
namespace HOT1.Models
{
	
	public class DistanceConverterModel
	{
		[Required(ErrorMessage = "Please enter distance.")]
		[Range(1, 500, ErrorMessage = "Distance must be between 1 and 500.")]
		public int? DistanceInInches { get; set; }

		[Required(ErrorMessage = "Please enter distance.")]
		[Range(1, 500, ErrorMessage = "Distance must be between 1 and 500.")]
		public int? DistanceInCentimeters { get; set; }

		public decimal? CalculateDistance()
		{
			DistanceInCentimeters = (int?)(DistanceInInches * 2.54M);
			decimal? distance = DistanceInCentimeters;

			return distance;
		}
	}
}
