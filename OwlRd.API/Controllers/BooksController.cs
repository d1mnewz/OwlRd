using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OwlRd.API.Controllers.Common;
using OwlRd.API.Models;

namespace OwlRd.API.Controllers
{
	public class BooksController : ApiController
	{
		[HttpGet, Route("")]
		public List<BookThumbnailViewModel> GetBooks()
		{
			return new List<BookThumbnailViewModel>
			{
				new BookThumbnailViewModel(1, "https://images-na.ssl-images-amazon.com/images/I/91NJTuwDDhL._SL1500_.jpg",
					"Alice in Wonderland")
			};
		}
	}
}