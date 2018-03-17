using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OwlRd.API.Controllers.Common;

namespace OwlRd.API.Controllers
{
	public class BooksController : ApiController
	{
		[HttpGet, Route("")]
		public List<BookThumbnailViewModel> GetBooks()
		{
			Console.WriteLine("Request started");
			return new List<BookThumbnailViewModel>
			{
				new BookThumbnailViewModel(Guid.NewGuid(), "https://images-na.ssl-images-amazon.com/images/I/91NJTuwDDhL._SL1500_.jpg",
					"Alice in Wonderland")
			};
		}
	}
}