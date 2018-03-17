using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace OwlRd.API.Controllers
{
	public class BooksController : ApiController
	{
		[HttpGet, Route("Books")]
		public List<BookThumbnailViewModel> GetBooks()
		{
			return new List<BookThumbnailViewModel>
			{
				new BookThumbnailViewModel(Guid.NewGuid(), "https://images-na.ssl-images-amazon.com/images/I/91NJTuwDDhL._SL1500_.jpg",
					"Alice in Wonderland")
			};
		}
	}
}