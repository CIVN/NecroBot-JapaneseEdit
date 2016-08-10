using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoGo.NecroBot.CLI
{
	public static class ConvertItemName
	{
		public static string ToJapanese(string itemId)
		{
			var i = 0;
			var jp_name = "";

			foreach (var en in ItemId_English)
			{
				if (en == itemId.ToUpper())
				{
					jp_name = ItemId_Japanese[i];
					break;
				}

				i++;
			}

			return jp_name;
		}

		public static string ItemStringToJapanese(string itemString)
		{
			var i = 0;
			var jp_name = "";

			foreach (var en in Items_English)
			{
				if (itemString.Contains(en))
				{
					itemString = itemString.Replace(en, Items_Japanese[i]);
				}

				i++;
			}

			jp_name = itemString;

			return jp_name;
		}

		private static string[] Items_English = new string[]
		{
			"ItemPokeBall",
			"ItemGreatBall",
			"ItemUltraBall",
			"ItemMasterBall",
			"ItemPotion",
			"ItemSuperPotion",
			"ItemHyperPotion",
			"ItemMaxPotion",
			"ItemRevive",
			"ItemMaxRevive",
			"ItemRazzBerry",
		};

		private static string[] Items_Japanese = new string[]
		{
			"モンスターボール",
			"スーパーボール",
			"ハイパーボール",
			"マスターボール",
			"キズぐすり",
			"いいキズぐすり",
			"すごいキズぐすり",
			"まんたんのくすり",
			"げんきのかけら",
			"げんきのかたまり",
			"ズリの実",
		};

		private static string[] ItemId_English = new string[]
		{
			"ItemUnknown",
			"ItemPokeBall",
			"ItemGreatBall",
			"ItemUltraBall",
			"ItemMasterBall",
			"ItemPotion",
			"ItemSuperPotion",
			"ItemHyperPotion",
			"ItemMaxPotion",
			"ItemRevive",
			"ItemMaxRevive",
			"ItemLuckyEgg",
			"ItemIncenseOrdinary",
			"ItemIncenseSpicy",
			"ItemIncenseCool",
			"ItemIncenseFloral",
			"ItemTroyDisk",
			"ItemXAttack",
			"ItemXDefense",
			"ItemXMiracle",
			"ItemRazzBerry",
			"ItemBlukBerry",
			"ItemNanabBerry",
			"ItemWeparBerry",
			"ItemPinapBerry",
			"ItemSpecialCamera",
			"ItemIncubatorBasicUnlimited",
			"ItemIncubatorBasic",
			"ItemPokemonStorageUpgrade",
			"ItemItemStorageUpgrade"
		};

		private static string[] ItemId_Japanese = new string[]
		{
			"不明なアイテム",
			"モンスターボール",
			"スーパーボール",
			"ハイパーボール",
			"マスターボール",
			"キズぐすり",
			"いいキズぐすり",
			"すごいキズぐすり",
			"まんたんのくすり",
			"げんきのかけら",
			"げんきのかたまり",
			"しあわせタマゴ",
			"おこう",
			"ItemIncenseSpicy",
			"ItemIncenseCool",
			"ItemIncenseFloral",
			"ItemTroyDisk",
			"ItemXAttack",
			"ItemXDefense",
			"ItemXMiracle",
			"ズリの実",
			"ItemBlukBerry",
			"ItemNanabBerry",
			"ItemWeparBerry",
			"ItemPinapBerry",
			"カメラ",
			"ムゲンふかそうち",
			"ふかそうち",
			"ポケモンボックス",
			"バックアップ"
		};
	}
}
