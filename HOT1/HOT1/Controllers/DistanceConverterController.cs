using HOT1.Models;
using Microsoft.AspNetCore.Mvc;


namespace HOT1.Controllers
{
	
	public class DistanceConverterController : Controller
	{

		[HttpGet]
		public IActionResult Index()
		{		
			ViewBag.IN = 0;
			return View();
		}
		[HttpPost]
		public IActionResult Index(DistanceConverterModel model)
		{
			if(ModelState.IsValid)
			{
				ViewBag.IN = model.CalculateDistance();
			}
			else
			{
				ViewBag.IN = 0;
			}
			return View(model);
		}
	}
}
