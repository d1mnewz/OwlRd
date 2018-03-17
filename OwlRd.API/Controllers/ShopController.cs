using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OwlRd.API.Controllers.Common;
using OwlRd.API.Models;

namespace OwlRd.API.Controllers
{
	public class ShopController : ApiController
	{
		[HttpGet, Route("")]
		public List<ShopItemViewModel> GetShopItems()
		{
			return new List<ShopItemViewModel>
			{
				new ShopItemViewModel(1, "Glasses", "http://www.stickpng.com/assets/images/584999937b7d4d76317f5ffd.png", ShopItemType.EquipHead),
				new ShopItemViewModel(2,
					"Cowboy hat",
					"http://hddfhm.com/images/clipart-cowboy-hat-18.png",
					ShopItemType.EquipHead)
			};
		}
	}
}