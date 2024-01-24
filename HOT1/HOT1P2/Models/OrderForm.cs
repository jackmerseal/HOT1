using System.ComponentModel.DataAnnotations;
namespace HOT1P2.Models
{
	public class OrderForm
	{
		[Required(ErrorMessage = "Please enter a quantity.")]
		public int Quantity { get; set; }
		public string? DiscountCode { get; set; }
		public string DiscountMessage { get; set; }
		public decimal? PricePerShirt { get; set; }
		public int? Subtotal { get; set; }
		public double? Tax { get; set; }
		public int? Total { get; set; }

		public decimal? GetSubtotal()
		{
			decimal subtotal = 0;
			return subtotal;
		}
		public decimal? GetDiscount()
		{
			decimal discount = 0;
			if(DiscountCode == "6175")
			{
				discount = (decimal)(Subtotal * 0.30);
			} 
			else if(DiscountCode == "1390")
			{
				discount = (decimal)(Subtotal * 0.20);
			} 
			else if(DiscountCode == "BB88")
			{
				discount = (decimal)(Subtotal * 0.15);
			}
			else
			{
				discount = 0;
			}
			return discount;
		}
		public double GetTax()
		{
			double tax = 0;
			Tax = Subtotal * 0.08;
			return tax;
		}

		public decimal? CalculateTotal()
		{
			decimal? discount = GetDiscount();
			double? tax = GetTax();
			decimal? total = 0;
			for (int i = 0; i < discount; i++)
			{
				total = (decimal?)(Subtotal + tax);
			}
			return total;
		}
	}
}
