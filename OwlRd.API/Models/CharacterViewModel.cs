using System;
using System.Drawing;

namespace OwlRd.API.Models
{
	public class CharacterViewModel
	{
		public CharacterViewModel(Guid id, string name, Point position)
		{
			Id = id;
			Name = name;
			Position = position;
		}

		public Guid Id { get; set; }
		public string Name { get; set; }
		public Point Position { get; set; }
	}
}