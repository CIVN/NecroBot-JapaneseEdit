using System;

namespace PoGo.NecroBot.CLI
{
	public class AddToDataView
	{
		public static void AddDataPokemon(string PokemonName, double PokemonLevel, int PokemonCP, int PokemonMaxCP, double PokemonIV, int EXP, int Candies)
		{
			Program.result.dataGridView1.Rows.Add();
			Program.result.dataGridView1[0, Program.a].Value = Program.a + 1;
			Program.result.dataGridView1[1, Program.a].Value = PokemonName;
			Program.result.dataGridView1[2, Program.a].Value = PokemonLevel;
			Program.result.dataGridView1[3, Program.a].Value = PokemonCP;
			Program.result.dataGridView1[4, Program.a].Value = PokemonMaxCP;
			Program.result.dataGridView1[5, Program.a].Value = PokemonIV;
			Program.result.dataGridView1[6, Program.a].Value = EXP;
			Program.result.dataGridView1[7, Program.a].Value = Candies;
			Program.a++;
		}

		public static void AddDataPokeStop(string Name, string Item, int Gems, int EXP)
		{
			Program.result.dataGridView2.Rows.Add();
			Program.result.dataGridView2[0, Program.b].Value = Program.b + 1;
			Program.result.dataGridView2[1, Program.b].Value = Name;
			Program.result.dataGridView2[2, Program.b].Value = Item;
			Program.result.dataGridView2[3, Program.b].Value = Gems;
			Program.result.dataGridView2[4, Program.b].Value = EXP;
			Program.b++;
		}

		public static void AddDataEvolve(string PokemonName, int EXP)
		{
			Program.result.dataGridView3.Rows.Add();
			Program.result.dataGridView3[0, Program.c].Value = Program.c + 1;
			Program.result.dataGridView3[1, Program.c].Value = PokemonName;
			Program.result.dataGridView3[2, Program.c].Value = EXP;
			Program.c++;
		}

		public static void AddDataTransfer(string Name, int CP, int BestCP, double IV, double BestIV, int Candies)
		{
			Program.result.dataGridView4.Rows.Add();
			Program.result.dataGridView4[0, Program.d].Value = Program.d + 1;
			Program.result.dataGridView4[1, Program.d].Value = Name;
			Program.result.dataGridView4[2, Program.d].Value = CP;
			Program.result.dataGridView4[3, Program.d].Value = BestCP;
			Program.result.dataGridView4[4, Program.d].Value = Math.Round(IV);
			Program.result.dataGridView4[5, Program.d].Value = Math.Round(BestIV);
			Program.result.dataGridView4[6, Program.d].Value = Candies;
			Program.d++;
		}
	}
}
