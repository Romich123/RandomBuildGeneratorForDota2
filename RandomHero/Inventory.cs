namespace RandomHero
{
	internal class Inventory
	{
		private Item[] mainSlots = new Item[6];
		private Item[] extraSlots = new Item[3];

		public IEnumerable<Item> MainSlots => mainSlots;
		public IEnumerable<Item> ExtraSlots => extraSlots;

		public void ReplaceMainSlotWithNew(int index, Patch patch, int goldThreshold, bool allowRecipes)
		{
			mainSlots[index] = patch.GetRandomItem(goldThreshold, allowRecipes);
		}

		public static Inventory GenerateRandomInventory(Patch patch, int goldThreshold, bool allowRecipes)
		{
			var result = new Inventory
			{
				mainSlots = patch.GetRandomItems(6,
												(x) =>
													(!x.IsBanned &&
													x.Cost > goldThreshold && 
													(allowRecipes || !x.Recipe))
													|| x.IsConsumable
												)
			};

			var consumablesInMainSlots = result.mainSlots.Count(x => x.IsConsumable);

			var notUsedConsumables = patch.GetRandomItems(3 - consumablesInMainSlots, (x) => x.IsConsumable && !result.mainSlots.Contains(x)).ToList();

			var extraItems = patch.GetRandomItems(consumablesInMainSlots,
												(x) => 
													x.Cost > goldThreshold &&
													(allowRecipes || !x.Recipe) && 
													!x.IsConsumable &&
													!result.mainSlots.Contains(x)
												).ToList();

			extraItems.AddRange(notUsedConsumables);

			result.extraSlots = extraItems.ToArray();

			return result;
		}
	}
}
