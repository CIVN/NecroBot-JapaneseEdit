using PokemonGo.RocketAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoGo.NecroBot.CLI
{
	public partial class ResultForm : Form
	{
		public ResultForm()
		{
			InitializeComponent();
		}

		private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				MessageBox.Show("このウィンドウは閉じることができません。\nアプリケーションを閉じるにはコンソールウィンドウを閉じてください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				e.Cancel = true;
			}
		}

		private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var value = dataGridView1[e.ColumnIndex, e.RowIndex].Value;

			if (value != null)
			{
				var dialog = new PokemonDialog();
				dialog.value = value.ToString();

				if (ConvertPokemonName.Pokemons_JapaneseNames.Contains(dialog.value))
				{
					dialog.Show();
				}
			}
		}

		private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var value = dataGridView2[e.ColumnIndex, e.RowIndex].Value;

			if (value != null)
			{
				var dialog = new PokemonDialog();
				dialog.value = value.ToString();

				if (ConvertPokemonName.Pokemons_JapaneseNames.Contains(dialog.value))
				{
					dialog.Show();
				}
			}
		}

		private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var value = dataGridView3[e.ColumnIndex, e.RowIndex].Value;

			if (value != null)
			{
				var dialog = new PokemonDialog();
				dialog.value = value.ToString();

				if (ConvertPokemonName.Pokemons_JapaneseNames.Contains(dialog.value))
				{
					dialog.Show();
				}
			}
		}

		private void dataGridView4_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var value = dataGridView4[e.ColumnIndex, e.RowIndex].Value;

			if (value != null)
			{
				var dialog = new PokemonDialog();
				dialog.value = value.ToString();

				if (ConvertPokemonName.Pokemons_JapaneseNames.Contains(dialog.value))
				{
					dialog.Show();
				}
			}
		}
	}
}
