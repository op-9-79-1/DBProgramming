namespace coffershop1
{
	partial class UserManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManager));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.button_Refresh = new System.Windows.Forms.Button();
			this.button_plus = new System.Windows.Forms.Button();
			this.dataGridView_Menu = new System.Windows.Forms.DataGridView();
			this.button_del = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Menu)).BeginInit();
			this.SuspendLayout();
			// 
			// button_Refresh
			// 
			this.button_Refresh.Location = new System.Drawing.Point(707, 35);
			this.button_Refresh.Name = "button_Refresh";
			this.button_Refresh.Size = new System.Drawing.Size(80, 23);
			this.button_Refresh.TabIndex = 11;
			this.button_Refresh.Text = "새로고침";
			this.button_Refresh.UseVisualStyleBackColor = true;
			this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
			// 
			// button_plus
			// 
			this.button_plus.BackColor = System.Drawing.Color.White;
			this.button_plus.Image = ((System.Drawing.Image)(resources.GetObject("button_plus.Image")));
			this.button_plus.Location = new System.Drawing.Point(707, 64);
			this.button_plus.Name = "button_plus";
			this.button_plus.Size = new System.Drawing.Size(38, 26);
			this.button_plus.TabIndex = 9;
			this.button_plus.UseVisualStyleBackColor = false;
			this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
			// 
			// dataGridView_Menu
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			this.dataGridView_Menu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Menu.Location = new System.Drawing.Point(11, 96);
			this.dataGridView_Menu.MultiSelect = false;
			this.dataGridView_Menu.Name = "dataGridView_Menu";
			this.dataGridView_Menu.RowTemplate.Height = 23;
			this.dataGridView_Menu.Size = new System.Drawing.Size(776, 319);
			this.dataGridView_Menu.TabIndex = 8;
			// 
			// button_del
			// 
			this.button_del.BackColor = System.Drawing.Color.White;
			this.button_del.Image = ((System.Drawing.Image)(resources.GetObject("button_del.Image")));
			this.button_del.Location = new System.Drawing.Point(749, 64);
			this.button_del.Name = "button_del";
			this.button_del.Size = new System.Drawing.Size(38, 26);
			this.button_del.TabIndex = 13;
			this.button_del.UseVisualStyleBackColor = false;
			this.button_del.Click += new System.EventHandler(this.button_del_Click);
			// 
			// UserManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button_del);
			this.Controls.Add(this.button_Refresh);
			this.Controls.Add(this.button_plus);
			this.Controls.Add(this.dataGridView_Menu);
			this.Name = "UserManager";
			this.Text = "UserManager";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Menu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_Refresh;
		private System.Windows.Forms.Button button_plus;
		private System.Windows.Forms.DataGridView dataGridView_Menu;
		private System.Windows.Forms.Button button_del;
	}
}