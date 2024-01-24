using System.ComponentModel.DataAnnotations;
namespace HOT1P2.Models
{
    public class OrderForm
    {
        [Required(ErrorMessage = "Please enter a quantity.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public int Quantity { get; set; }

        public string DiscountCode { get; set; }

        public decimal CalculateSubtotal()
        {
            decimal subtotal = Quantity * 15.00M;
            return subtotal;
        }

        public decimal CalculateDiscount()
        {
            decimal discount = 0;
			if (DiscountCode == "6175")
			{
                discount = (decimal)(Quantity * 0.30);
			}
            else if(DiscountCode == "1390")
            {
                discount = (decimal)(Quantity * 0.20);
            }
            else if(DiscountCode == "BB88")
            {
                discount = (decimal)(Quantity * 0.10);
            }
			return discount;
        }

        public double CalculateTax()
        {
			double tax = (double)(Quantity * 0.08);
			return tax;
        }

        public decimal CalculateTotal()
        {
            decimal subtotal = CalculateSubtotal();
            decimal discount = CalculateDiscount();
            double tax = CalculateTax();

            decimal total = subtotal - discount + (decimal)tax;
            return total;
        }
    }
}
