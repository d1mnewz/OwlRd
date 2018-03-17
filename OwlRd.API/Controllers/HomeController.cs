using System;
using Microsoft.AspNetCore.Mvc;

namespace OwlRd.API.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet, Route("")]
		public ApplicationSettings Get()
		{
			return new ApplicationSettings(DateTime.UtcNow);
		}
	}

	public class ApplicationSettings
	{
		public ApplicationSettings(DateTime current)
		{
			CurrentUtc = current;
		}

		public DateTime CurrentUtc { get; set; }
	}
}