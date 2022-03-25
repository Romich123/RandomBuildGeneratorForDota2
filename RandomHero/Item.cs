using System.Text.Json;

namespace RandomHero
{
	internal class Item
	{
		public enum ConsumableItemsIds
		{
			Aghanim = 108,
			MoonShard = 247,
			AghanimsShard = 609
		}

		public enum BannedItems
		{
			AghanimsRecipe = 107,
			AghanimsBlessingsRecipe = 270,
			AghanimsBlessing = 271,
			Dagon1 = 104,
			Dagon2 = 201,
			Dagon3 = 202,
			Dagon4 = 203,
			RecipeNecronomicons1 = 105,
			RecipeNecronomicons2 = 191,
			RecipeNecronomicons3 = 192,
			Necronomicon1 = 106,
			Necronomicon2 = 193,
			Necronomicon3 = 194,
			CommonItemsMaximumId = 271
		}

		public bool IsConsumable 
		{
			get
			{
				var consumables = (int[])Enum.GetValues(typeof(ConsumableItemsIds));

				return consumables.Contains(Id);
			}
		}

		public bool IsBanned
		{
			get
			{
				var consumables = (int[])Enum.GetValues(typeof(BannedItems));

				return consumables.Contains(Id) || Id > (int)BannedItems.CommonItemsMaximumId;
			}
		}

		public bool Recipe;
		public int Id;
		public int Cost;
		public string Name = "";
		public string Localized_Name = "";

		public override string ToString()
		{
			return JsonSerializer.Serialize(this);
		}
	}
}
