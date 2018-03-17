using System.Collections.Generic;
using System.Drawing;
using Microsoft.AspNetCore.Mvc;
using OwlRd.API.Controllers.Common;
using OwlRd.API.Models;

namespace OwlRd.API.Controllers
{
	public class CharacterController : ApiController
	{
		[HttpGet, Route("")]
		public List<CharacterViewModel> GetCharacters()
		{
			return new List<CharacterViewModel>
			{
				new CharacterViewModel(1, "Alice Owl", new Point(10, 5)),
				new CharacterViewModel(2,
					"MobyDick Owl",
					new Point(15, 10))
			};
		}
	}
}