using System;
using System.Collections.Generic;
using OwlRd.API.Models;

namespace OwlRd.API.Controllers
{
	public class ShopController : ApiController
	{
		public List<ShopItemViewModel> GetShopItems()
		{
			return new List<ShopItemViewModel> { new ShopItemViewModel(Guid.NewGuid(), "dummy", "dummy", ShopItemType.EquipHead) };
		}
	}
}