using POGOProtos.Enums;
using PokemonGo.RocketAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoGo.NecroBot.CLI
{
	public partial class PokemonDialog : Form
	{
		public string value;

		public PokemonDialog()
		{
			InitializeComponent();
		}

		private void PokemonDialog_Load(object sender, EventArgs e)
		{
			var i = 0;
			var path = "";

			foreach (var jp in ConvertPokemonName.Pokemons_JapaneseNames)
			{
				if (value == jp)
				{
					path = Path.Combine(Environment.CurrentDirectory, "PokemonPictures", "Pokemon_" + i.ToString() + ".png");
					break;
				}

				i++;
			}

			pictureBox1.ImageLocation = path;
		}
	}
}
