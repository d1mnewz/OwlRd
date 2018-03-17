using System;

namespace OwlRd.API.Controllers
{
	public class BookThumbnailViewModel
	{
		public BookThumbnailViewModel(Guid id, string thumbnailUrl, string title)
		{
			Id = id;
			ThumbnailUrl = thumbnailUrl;
			Title = title;
		}

		public Guid Id { get; set; }
		public string ThumbnailUrl { get; set; }
		public string Title { get; set; }
	}
}