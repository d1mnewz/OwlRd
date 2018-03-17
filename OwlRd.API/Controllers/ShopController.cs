using System;
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
			return new List<ShopItemViewModel> { new ShopItemViewModel(Guid.NewGuid(), "dummy", "dummy", ShopItemType.EquipHead) };
		}
	}
}