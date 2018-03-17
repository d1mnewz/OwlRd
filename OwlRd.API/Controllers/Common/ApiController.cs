using Microsoft.AspNetCore.Mvc;

namespace OwlRd.API.Controllers.Common
{
	[Route("api/[controller]")]
	public abstract class ApiController : Controller
	{
	}
}