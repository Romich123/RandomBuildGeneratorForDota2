using System.Text.Json;

namespace RandomHero
{
	internal class Hero
	{
		public int Id;
		public string Name = string.Empty;
		public string Localized_Name = string.Empty;
		public string Primary_Attr = string.Empty;
		public string Attack_Type = string.Empty;

		public override string ToString()
		{
			return JsonSerializer.Serialize(this);
		}
	}
}
