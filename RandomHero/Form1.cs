using System.ComponentModel;

namespace RandomHero
{
	public partial class Form1 : Form
	{
		private static readonly HttpClient client = new HttpClient();
		private static readonly string steamApiKey = "your api key, you can get it on https://steamcommunity.com/dev/apikey";

		private static readonly string getHeroesRequest = "https://api.opendota.com/api/heroes/";
		private static readonly string getItemsRequest = "http://api.steampowered.com/IEconDOTA2_570/GetGameItems/v0001/";

		private static readonly string heroIconsAssets = "https://steamcdn-a.akamaihd.net/apps/dota2/images/dota_react/heroes/";
		private static readonly string itemsIconsAssets = "https://cdn.cloudflare.steamstatic.com/apps/dota2/images//items/";

		private static readonly string reserveItemsFile = "saves/items.txt";
		private static readonly string reserveHeroesFile = "saves/heroes.txt";
		private static readonly string newItemsFile = "saves/newItems.txt";
		private static readonly string newHeroesFile = "saves/newHeroes.txt";
		private static readonly string emptyInventorySlotImageUrl = "emptySlot.jpg";

		private static string language = "ru";

		private static readonly int maximumGoldTreshold = 6000;
		
		private readonly PictureBox[] inventorySlots;
		private readonly ToolTip toolTip;

		private Hero heroSelected;
		private Inventory inventory;

		private int itemsGoldTreshold = 3850;
		private Patch currentPatch;

		public Form1()
		{
			InitializeComponent();
			heroAvatar.MouseHover += HeroAvatarMouseHover;
			heroAvatar.Click += HeroAvatarClicked;

			currentPatch = LoadPatch();

			inventorySlots = new PictureBox[9]
			{
				itemBox1,
				itemBox2,
				itemBox3,
				itemBox4,
				itemBox5,
				itemBox6,
				specialItemBox1,
				specialItemBox2,
				specialItemBox3
			};
			toolTip = new ToolTip();

			foreach (var slot in inventorySlots)
			{
				slot.MouseHover += ItemSlotHovered;
				slot.Click += ItemSlotClicked;
				slot.LoadCompleted += ItemSlotLoaded;
			}

			(heroSelected, inventory) = GenerateNewHeroAndInventory();
			RedrawInventory(inventory);
			SelectHero(heroSelected);
		}


		private void ItemSlotLoaded(object? sender, AsyncCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				var indexOfSender = Array.IndexOf(inventorySlots, sender);

				inventory.ReplaceMainSlotWithNew(indexOfSender, currentPatch, itemsGoldTreshold, false);
				RedrawInventorySlot(indexOfSender);
			}
		}

		private void ItemSlotClicked(object? sender, EventArgs e)
		{
			var indexOfSender = Array.IndexOf(inventorySlots, sender);

			if (indexOfSender < 6)
			{
				inventory.ReplaceMainSlotWithNew(indexOfSender, currentPatch, itemsGoldTreshold, false);
				RedrawInventorySlot(indexOfSender);
			}
		}

		private void ItemSlotHovered(object? sender, EventArgs e)
		{
			var indexOfSender = Array.IndexOf(inventorySlots, sender);

			var item = indexOfSender < 6 ? inventory.MainSlots.ElementAt(indexOfSender) : inventory.ExtraSlots.ElementAt(indexOfSender - 6);

			if (item != null)
				toolTip.SetToolTip(sender as PictureBox, item.Localized_Name);
		}

		private void HeroAvatarClicked(object? sender, EventArgs e)
		{
			SelectHero(currentPatch.GetRandomHero());
		}

		private void HeroAvatarMouseHover(object? sender, EventArgs e)
		{
			toolTip.SetToolTip(heroAvatar, heroSelected.Localized_Name);
		}

		private void UpdateButton_Click(object? sender, EventArgs e)
		{
			currentPatch = DownloadActualPatch();
		}

		private void MinimumGoldChanged(object sender, EventArgs e)
		{
			if (int.TryParse(minimumGold.Text, out itemsGoldTreshold))
			{
				if (itemsGoldTreshold > maximumGoldTreshold)
				{
					minimumGold.Text = maximumGoldTreshold.ToString();
				}
			}
			else
			{
				minimumGold.Text = "3850";
			}
		}

		private void GenerateNewButton_Click(object sender, EventArgs e)
		{
			(heroSelected, inventory) = GenerateNewHeroAndInventory();
			RedrawInventory(inventory);
			SelectHero(heroSelected);
		}

		private (Hero, Inventory) GenerateNewHeroAndInventory()
		{
			return (currentPatch.GetRandomHero(), Inventory.GenerateRandomInventory(currentPatch, itemsGoldTreshold, false));
		}

		private void RedrawInventorySlot(int index)
		{
			var item = index < 6 ? inventory.MainSlots.ElementAt(index) : inventory.ExtraSlots.ElementAt(index - 6);
			
			inventorySlots[index].ImageLocation = GetItemIconUrlByItem(item);
		}

		private void RedrawInventory(Inventory inventory)
		{
			var mainSlots = inventory.MainSlots.ToArray();
			var consumables = inventory.ExtraSlots.ToArray();

			for (int i = 0; i < 6; i++)
			{
				inventorySlots[i].ImageLocation = GetItemIconUrlByItem(mainSlots[i]); 
			}

			for (int i = 0; i < 3; i++)
			{
				if (consumables[i] != null)
					inventorySlots[6 + i].ImageLocation = GetItemIconUrlByItem(consumables[i]);
				else
					inventorySlots[6 + i].ImageLocation = emptyInventorySlotImageUrl;
			}
		}

		private void SelectHero(Hero hero)
		{
			heroSelected = hero;

			heroAvatar.ImageLocation = GetHeroIconUrlByHero(hero);
		}

		private static string GetHeroIconUrlByHero(Hero hero)
		{
			return $"{heroIconsAssets}{hero.Name.Remove(0, 14)}.png";
		}

		private static string GetItemIconUrlByItem(Item item)
		{
			return $"{itemsIconsAssets}{item.Name.Remove(0, 5)}_lg.png";
		}

		private static Patch LoadPatch()
		{
			Patch result;

			//если не получилось загрузить какую либо версию, тогда скачиваем её из интернета
			try
			{
				//если не удалось загрузить самую новую версию, тогда загружаем резервную, а если получилось то заменяем резервную актуальной
				try
				{
					result = LoadActualPatch();
				}
				catch
				{
					result = LoadReservePatch();
				}
				finally
				{
					ReplaceReservePatchWithActual();
				}
			}
			catch
			{
				result = DownloadActualPatch();
			}

			return result;
		}

		private static Patch LoadReservePatch()
		{
			var jsonHeroes = File.ReadAllText(reserveHeroesFile);
			var jsonItems = File.ReadAllText(reserveItemsFile);

			return new Patch(jsonHeroes, jsonItems);
		}

		private static Patch LoadActualPatch()
		{
			var jsonHeroes = File.ReadAllText(newHeroesFile);
			var jsonItems = File.ReadAllText(newItemsFile);

			return new Patch(jsonHeroes, jsonItems);
		}

		private static void ReplaceReservePatchWithActual()
		{
			var jsonHeroes = File.ReadAllText(newHeroesFile);
			var jsonItems = File.ReadAllText(newItemsFile);

			File.WriteAllText(reserveHeroesFile, jsonHeroes);
			File.WriteAllText(reserveItemsFile, jsonItems);
		}

		private static Patch DownloadActualPatch()
		{
			var heroResponse = client.GetAsync($"{getHeroesRequest}").GetAwaiter().GetResult();
			var itemResponse = client.GetAsync($"{getItemsRequest}?key={steamApiKey}&language=\"{language}\"").GetAwaiter().GetResult();

			var jsonHeroes = heroResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();
			var jsonItems = itemResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();
			jsonItems = jsonItems.Remove(0, 21);
			jsonItems = jsonItems.Remove(jsonItems.Length - 19, 19);

			File.WriteAllText(newHeroesFile, jsonHeroes);
			File.WriteAllText(newItemsFile, jsonItems);

			return new Patch(jsonHeroes, jsonItems);
		}
	}
}