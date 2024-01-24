using Microsoft.AspNetCore.Mvc;
using HOT1P2.Models;
namespace HOT1.Controllers
{
	public class OrderFormController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.SUBTOTAL = 0;
			ViewBag.TAX = 0;
			ViewBag.TOTAL = 0;
			return View();
		}
		[HttpPost]
		public IActionResult Index(OrderForm model)
		{
			if(ModelState.IsValid)
			{
				ViewBag.SUBTOTAL = model.GetSubtotal();
			}
			else
			{
				ViewBag.SUBTOTAL = 0;
				ViewBag.TAX = 0;
				ViewBag.TOTAL = 0;
			}
			return View(model);
		}
	}
}
