using Nancy.Json;

namespace RandomHero
{
	internal class Patch
	{
		private List<Hero> heroes;
		private List<Item> items;

		public IEnumerable<Hero> Heroes => heroes;
		public IEnumerable<Item> Items => items;

		public Patch(string jsonHeroes, string jsonItems)
		{
			JavaScriptSerializer ser = new JavaScriptSerializer();

			heroes = ser.Deserialize<List<Hero>>(jsonHeroes);
			items = ser.Deserialize<List<Item>>(jsonItems);
		}

		public Hero GetRandomHero()
		{
			return heroes[new Random().Next(0, heroes.Count)];
		}

		public Hero GetRandomHero(Predicate<Hero> filter)
		{
			Hero result;

			do
			{
				result = heroes[new Random().Next(0, heroes.Count)];
			} while (!filter(result));

			return result;
		}

		public Item GetRandomItem(int goldThreshold, bool allowRecipes)
		{
			var goodItems = items.FindAll(item => !item.IsBanned && item.Cost >= goldThreshold && (allowRecipes || !item.Recipe));

			Item result = goodItems[new Random().Next(0, goodItems.Count)];

			return result;
		}

		public Item GetRandomItem(Predicate<Item> filter)
		{
			var goodItems = items.FindAll(filter);
			goodItems = goodItems.FindAll(x => !x.IsBanned);

			Item result = goodItems[new Random().Next(0, goodItems.Count)];

			return result;
		}

		public Item[] GetRandomItems(int count, int goldThreshold, bool allowRecipes)
		{
			var goodItems = items.FindAll(item => item.Cost >= goldThreshold && (allowRecipes || !item.Recipe));

			return goodItems.Shuffle().Take(count).ToArray();
		}

		public Item[] GetRandomItems(int count, Predicate<Item> filter)
		{
			var goodItems = items.FindAll(filter);

			return goodItems.Shuffle().Take(count).ToArray();
		}

		public Item[] GetAllConsumableItems()
		{
			return items.FindAll(x => x.IsConsumable).ToArray();
		}
	}
}
