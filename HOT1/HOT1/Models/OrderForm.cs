using System.ComponentModel.DataAnnotations;
namespace HOT1.Models
{
	public class OrderForm
	{
		[Required(ErrorMessage = "Please enter a quantity.")]
		public int Quantity { get; set; }
		public string? DiscountCode { get; set; }
		public string DiscountMessage { get; set; }
		public decimal? PricePerShirt { get; set; }
		public int? Subtotal { get; set; }
		public int? Tax { get; set; }
		public int? Total { get; set; }

	}
}
