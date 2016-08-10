namespace PoGo.NecroBot.CLI
{
	partial class ResultForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.ポケモン = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.名前 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.進化レベル = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.最大CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.経験値 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.アメ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ポケストップ = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.アイテム = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ジェム = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.進化 = new System.Windows.Forms.TabPage();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.経験値2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.転送 = new System.Windows.Forms.TabPage();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.tabControl1.SuspendLayout();
			this.ポケモン.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.ポケストップ.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.進化.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.転送.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.ポケモン);
			this.tabControl1.Controls.Add(this.ポケストップ);
			this.tabControl1.Controls.Add(this.進化);
			this.tabControl1.Controls.Add(this.転送);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.ItemSize = new System.Drawing.Size(210, 18);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(844, 441);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 1;
			// 
			// ポケモン
			// 
			this.ポケモン.Controls.Add(this.dataGridView1);
			this.ポケモン.Location = new System.Drawing.Point(4, 22);
			this.ポケモン.Name = "ポケモン";
			this.ポケモン.Padding = new System.Windows.Forms.Padding(3);
			this.ポケモン.Size = new System.Drawing.Size(836, 415);
			this.ポケモン.TabIndex = 2;
			this.ポケモン.Text = "ポケモン";
			this.ポケモン.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.名前,
            this.進化レベル,
            this.CP,
            this.最大CP,
            this.IV,
            this.経験値,
            this.アメ});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(830, 409);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
			// 
			// No
			// 
			this.No.HeaderText = "No";
			this.No.Name = "No";
			this.No.ReadOnly = true;
			this.No.Width = 50;
			// 
			// 名前
			// 
			this.名前.HeaderText = "名前";
			this.名前.Name = "名前";
			this.名前.ReadOnly = true;
			this.名前.Width = 150;
			// 
			// 進化レベル
			// 
			this.進化レベル.HeaderText = "進化レベル";
			this.進化レベル.Name = "進化レベル";
			this.進化レベル.ReadOnly = true;
			// 
			// CP
			// 
			this.CP.HeaderText = "CP";
			this.CP.Name = "CP";
			this.CP.ReadOnly = true;
			// 
			// 最大CP
			// 
			this.最大CP.HeaderText = "最大CP";
			this.最大CP.Name = "最大CP";
			this.最大CP.ReadOnly = true;
			// 
			// IV
			// 
			this.IV.HeaderText = "IV";
			this.IV.Name = "IV";
			this.IV.ReadOnly = true;
			// 
			// 経験値
			// 
			this.経験値.HeaderText = "経験値";
			this.経験値.Name = "経験値";
			this.経験値.ReadOnly = true;
			// 
			// アメ
			// 
			this.アメ.HeaderText = "アメ";
			this.アメ.Name = "アメ";
			this.アメ.ReadOnly = true;
			// 
			// ポケストップ
			// 
			this.ポケストップ.Controls.Add(this.dataGridView2);
			this.ポケストップ.Location = new System.Drawing.Point(4, 22);
			this.ポケストップ.Name = "ポケストップ";
			this.ポケストップ.Padding = new System.Windows.Forms.Padding(3);
			this.ポケストップ.Size = new System.Drawing.Size(836, 415);
			this.ポケストップ.TabIndex = 3;
			this.ポケストップ.Text = "ポケストップ";
			this.ポケストップ.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.アイテム,
            this.ジェム,
            this.dataGridViewTextBoxColumn3});
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 3);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowTemplate.Height = 21;
			this.dataGridView2.Size = new System.Drawing.Size(830, 409);
			this.dataGridView2.TabIndex = 2;
			this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "No";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 50;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "名前";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 150;
			// 
			// アイテム
			// 
			this.アイテム.HeaderText = "アイテム";
			this.アイテム.Name = "アイテム";
			this.アイテム.ReadOnly = true;
			this.アイテム.Width = 385;
			// 
			// ジェム
			// 
			this.ジェム.HeaderText = "ジェム";
			this.ジェム.Name = "ジェム";
			this.ジェム.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "経験値";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// 進化
			// 
			this.進化.Controls.Add(this.dataGridView3);
			this.進化.Location = new System.Drawing.Point(4, 22);
			this.進化.Name = "進化";
			this.進化.Padding = new System.Windows.Forms.Padding(3);
			this.進化.Size = new System.Drawing.Size(836, 415);
			this.進化.TabIndex = 0;
			this.進化.Text = "進化";
			this.進化.UseVisualStyleBackColor = true;
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.経験値2});
			this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView3.Location = new System.Drawing.Point(3, 3);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.RowTemplate.Height = 21;
			this.dataGridView3.Size = new System.Drawing.Size(830, 409);
			this.dataGridView3.TabIndex = 2;
			this.dataGridView3.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseDoubleClick);
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "No";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 50;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "名前";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 150;
			// 
			// 経験値2
			// 
			this.経験値2.HeaderText = "経験値";
			this.経験値2.Name = "経験値2";
			this.経験値2.ReadOnly = true;
			this.経験値2.Width = 585;
			// 
			// 転送
			// 
			this.転送.Controls.Add(this.dataGridView4);
			this.転送.Location = new System.Drawing.Point(4, 22);
			this.転送.Name = "転送";
			this.転送.Padding = new System.Windows.Forms.Padding(3);
			this.転送.Size = new System.Drawing.Size(836, 415);
			this.転送.TabIndex = 1;
			this.転送.Text = "転送";
			this.転送.UseVisualStyleBackColor = true;
			// 
			// dataGridView4
			// 
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
			this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView4.Location = new System.Drawing.Point(3, 3);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.ReadOnly = true;
			this.dataGridView4.RowTemplate.Height = 21;
			this.dataGridView4.Size = new System.Drawing.Size(830, 409);
			this.dataGridView4.TabIndex = 2;
			this.dataGridView4.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView4_CellMouseDoubleClick);
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "No";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 50;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.HeaderText = "名前";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Width = 150;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.HeaderText = "CP";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.HeaderText = "最大CP";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.HeaderText = "IV";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.HeaderText = "経験値";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.HeaderText = "アメ";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.ReadOnly = true;
			this.dataGridViewTextBoxColumn13.Width = 185;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "PokemonGo";
			// 
			// ResultForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(844, 441);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ResultForm";
			this.Text = "Result";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultForm_FormClosing);
			this.tabControl1.ResumeLayout(false);
			this.ポケモン.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ポケストップ.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.進化.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.転送.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.TabControl tabControl1;
		public System.Windows.Forms.TabPage ポケモン;
		public System.Windows.Forms.TabPage ポケストップ;
		public System.Windows.Forms.TabPage 進化;
		public System.Windows.Forms.TabPage 転送;
		public System.Windows.Forms.DataGridView dataGridView1;
		public System.Windows.Forms.DataGridView dataGridView2;
		public System.Windows.Forms.DataGridView dataGridView3;
		public System.Windows.Forms.DataGridView dataGridView4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn アイテム;
		private System.Windows.Forms.DataGridViewTextBoxColumn ジェム;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		public System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.DataGridViewTextBoxColumn No;
		private System.Windows.Forms.DataGridViewTextBoxColumn 名前;
		private System.Windows.Forms.DataGridViewTextBoxColumn 進化レベル;
		private System.Windows.Forms.DataGridViewTextBoxColumn CP;
		private System.Windows.Forms.DataGridViewTextBoxColumn 最大CP;
		private System.Windows.Forms.DataGridViewTextBoxColumn IV;
		private System.Windows.Forms.DataGridViewTextBoxColumn 経験値;
		private System.Windows.Forms.DataGridViewTextBoxColumn アメ;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn 経験値2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
	}
}