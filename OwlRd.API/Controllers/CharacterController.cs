using Microsoft.AspNetCore.Mvc;
using OwlRd.API.Controllers.Common;
using OwlRd.API.Models;

namespace OwlRd.API.Controllers
{
	public class CharacterController : ApiController
	{
		[HttpGet, Route("")]
		public CharacterViewModel GetBooks()
		{
			return new CharacterViewModel();
		}
	}
}