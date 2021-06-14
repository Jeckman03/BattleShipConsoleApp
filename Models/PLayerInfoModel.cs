using System;
using System.Collections.Generic;

namespace BattleShipConsoleLibrary.Models
{
	public class PlayerInfoModel
	{
		public List<GridSpotModel> ShipLocations { get; set; }
		public List<GridSpotModel> ShotGrid { get; set; }
	}
}