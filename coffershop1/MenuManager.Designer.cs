namespace coffershop1
{
	partial class MenuManager
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuManager));
			this.dataGridView_Menu = new System.Windows.Forms.DataGridView();
			this.button_revise = new System.Windows.Forms.Button();
			this.button_Refresh = new System.Windows.Forms.Button();
			this.button_plus = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Menu)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Menu
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dataGridView_Menu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Menu.Location = new System.Drawing.Point(12, 88);
			this.dataGridView_Menu.MultiSelect = false;
			this.dataGridView_Menu.Name = "dataGridView_Menu";
			this.dataGridView_Menu.RowTemplate.Height = 23;
			this.dataGridView_Menu.Size = new System.Drawing.Size(776, 319);
			this.dataGridView_Menu.TabIndex = 1;
			// 
			// button_revise
			// 
			this.button_revise.BackColor = System.Drawing.Color.White;
			this.button_revise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_revise.Image = ((System.Drawing.Image)(resources.GetObject("button_revise.Image")));
			this.button_revise.Location = new System.Drawing.Point(708, 56);
			this.button_revise.Name = "button_revise";
			this.button_revise.Size = new System.Drawing.Size(38, 26);
			this.button_revise.TabIndex = 6;
			this.button_revise.UseVisualStyleBackColor = false;
			this.button_revise.Click += new System.EventHandler(this.button_revise_Click);
			// 
			// button_Refresh
			// 
			this.button_Refresh.Location = new System.Drawing.Point(708, 27);
			this.button_Refresh.Name = "button_Refresh";
			this.button_Refresh.Size = new System.Drawing.Size(80, 23);
			this.button_Refresh.TabIndex = 7;
			this.button_Refresh.Text = "새로고침";
			this.button_Refresh.UseVisualStyleBackColor = true;
			this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
			// 
			// button_plus
			// 
			this.button_plus.BackColor = System.Drawing.Color.White;
			this.button_plus.Image = ((System.Drawing.Image)(resources.GetObject("button_plus.Image")));
			this.button_plus.Location = new System.Drawing.Point(752, 56);
			this.button_plus.Name = "button_plus";
			this.button_plus.Size = new System.Drawing.Size(38, 26);
			this.button_plus.TabIndex = 5;
			this.button_plus.UseVisualStyleBackColor = false;
			this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
			// 
			// MenuManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button_Refresh);
			this.Controls.Add(this.button_revise);
			this.Controls.Add(this.button_plus);
			this.Controls.Add(this.dataGridView_Menu);
			this.Name = "MenuManager";
			this.Text = "메뉴 관리";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Menu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Menu;
		private System.Windows.Forms.Button button_revise;
		private System.Windows.Forms.Button button_Refresh;
		private System.Windows.Forms.Button button_plus;
	}
}