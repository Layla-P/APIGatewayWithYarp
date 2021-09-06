using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FoodController : ControllerBase
	{
		private static readonly string[] Food = new[]
		{
			"Fish Taco", "Meat Taco", "Tofu Taco", "Chips and Dip", "French fries", "Taco salad", "Pico de Gallo"
		};

		private readonly ILogger<FoodController> _logger;

		public FoodController(ILogger<FoodController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public string Get()
		{
			var rng = new Random();
			var index = rng.Next(0, 6);
			return Food[index];
		}
	}
}
