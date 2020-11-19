namespace coffershop1
{
	partial class OrderSearch
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSearch));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.button_Refresh = new System.Windows.Forms.Button();
			this.button_revise = new System.Windows.Forms.Button();
			this.dataGridView_Menu = new System.Windows.Forms.DataGridView();
			this.button_del = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
			// button_revise
			// 
			this.button_revise.BackColor = System.Drawing.Color.White;
			this.button_revise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_revise.Image = ((System.Drawing.Image)(resources.GetObject("button_revise.Image")));
			this.button_revise.Location = new System.Drawing.Point(707, 64);
			this.button_revise.Name = "button_revise";
			this.button_revise.Size = new System.Drawing.Size(38, 26);
			this.button_revise.TabIndex = 10;
			this.button_revise.UseVisualStyleBackColor = false;
			this.button_revise.Click += new System.EventHandler(this.button_revise_Click);
			// 
			// dataGridView_Menu
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dataGridView_Menu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
			this.button_del.TabIndex = 12;
			this.button_del.UseVisualStyleBackColor = false;
			this.button_del.Click += new System.EventHandler(this.button_del_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "HH시 mm분";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(13, 68);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.ShowUpDown = true;
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
			this.dateTimePicker1.TabIndex = 13;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// OrderSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button_del);
			this.Controls.Add(this.button_Refresh);
			this.Controls.Add(this.button_revise);
			this.Controls.Add(this.dataGridView_Menu);
			this.Name = "OrderSearch";
			this.Text = "주문 검색";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Menu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_Refresh;
		private System.Windows.Forms.Button button_revise;
		private System.Windows.Forms.DataGridView dataGridView_Menu;
		private System.Windows.Forms.Button button_del;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}