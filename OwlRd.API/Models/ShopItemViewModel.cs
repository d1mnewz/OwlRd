using System;

namespace OwlRd.API.Models
{
	public class ShopItemViewModel
	{
		public ShopItemViewModel(Guid id, string name, string image, ShopItemType type)
		{
			Id = id;
			Name = name;
			Image = image;
			Type = type;
		}

		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public ShopItemType Type { get; set; }
	}

	public enum ShopItemType
	{
		EquipHead = 0
	}
}