using Microsoft.AspNetCore.Mvc;
using HOT1P2.Models;

namespace HOT1P2.Controllers
{
	public class OrderFormController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(OrderForm model)
		{
			if (ModelState.IsValid)
			{
				ViewBag.ST = model.CalculateSubtotal();
				ViewBag.T = model.CalculateTax();
				ViewBag.TL = model.CalculateTotal();
			}
			else
			{
				ViewBag.STL = 0;
				ViewBag.T = 0;
				ViewBag.TL = 0;
			}
			return View(model);
		}
	}
}
