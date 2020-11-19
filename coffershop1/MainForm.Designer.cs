namespace coffershop1
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelmaster = new System.Windows.Forms.Label();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.button_order_search = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.groupBox_master = new System.Windows.Forms.GroupBox();
			this.dataGridView_master = new System.Windows.Forms.DataGridView();
			this.button_master_1 = new System.Windows.Forms.Button();
			this.button_master_2 = new System.Windows.Forms.Button();
			this.button_master_3 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.관ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.사용자로그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.메뉴관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button_order = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_master)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelmaster
			// 
			this.labelmaster.AutoSize = true;
			this.labelmaster.Location = new System.Drawing.Point(503, 29);
			this.labelmaster.Name = "labelmaster";
			this.labelmaster.Size = new System.Drawing.Size(85, 12);
			this.labelmaster.TabIndex = 4;
			this.labelmaster.Text = "로그인 대기중.";
			// 
			// buttonLogout
			// 
			this.buttonLogout.Location = new System.Drawing.Point(672, 24);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(87, 23);
			this.buttonLogout.TabIndex = 5;
			this.buttonLogout.Text = "로그아웃";
			this.buttonLogout.UseVisualStyleBackColor = true;
			this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button_order);
			this.groupBox1.Controls.Add(this.flowLayoutPanel2);
			this.groupBox1.Controls.Add(this.flowLayoutPanel1);
			this.groupBox1.Controls.Add(this.button_order_search);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Location = new System.Drawing.Point(47, 79);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(712, 175);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "캐셔용 화면";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Location = new System.Drawing.Point(344, 47);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(347, 122);
			this.flowLayoutPanel2.TabIndex = 10;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 47);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 122);
			this.flowLayoutPanel1.TabIndex = 9;
			// 
			// button_order_search
			// 
			this.button_order_search.Location = new System.Drawing.Point(224, 18);
			this.button_order_search.Name = "button_order_search";
			this.button_order_search.Size = new System.Drawing.Size(75, 23);
			this.button_order_search.TabIndex = 7;
			this.button_order_search.Text = "주문 검색";
			this.button_order_search.UseVisualStyleBackColor = true;
			this.button_order_search.Click += new System.EventHandler(this.button_order_search_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(18, 20);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// groupBox_master
			// 
			this.groupBox_master.Location = new System.Drawing.Point(47, 287);
			this.groupBox_master.Name = "groupBox_master";
			this.groupBox_master.Size = new System.Drawing.Size(712, 175);
			this.groupBox_master.TabIndex = 8;
			this.groupBox_master.TabStop = false;
			this.groupBox_master.Text = "관리자용 화면";
			// 
			// dataGridView_master
			// 
			this.dataGridView_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_master.Location = new System.Drawing.Point(18, 19);
			this.dataGridView_master.Name = "dataGridView_master";
			this.dataGridView_master.RowTemplate.Height = 23;
			this.dataGridView_master.Size = new System.Drawing.Size(676, 150);
			this.dataGridView_master.TabIndex = 7;
			// 
			// button_master_1
			// 
			this.button_master_1.Location = new System.Drawing.Point(588, 260);
			this.button_master_1.Name = "button_master_1";
			this.button_master_1.Size = new System.Drawing.Size(53, 23);
			this.button_master_1.TabIndex = 9;
			this.button_master_1.Text = "(1)";
			this.button_master_1.UseVisualStyleBackColor = true;
			this.button_master_1.Click += new System.EventHandler(this.button_master1_Click);
			// 
			// button_master_2
			// 
			this.button_master_2.Location = new System.Drawing.Point(647, 260);
			this.button_master_2.Name = "button_master_2";
			this.button_master_2.Size = new System.Drawing.Size(53, 23);
			this.button_master_2.TabIndex = 10;
			this.button_master_2.Text = "(2)";
			this.button_master_2.UseVisualStyleBackColor = true;
			this.button_master_2.Click += new System.EventHandler(this.button_master2_Click);
			// 
			// button_master_3
			// 
			this.button_master_3.Location = new System.Drawing.Point(706, 260);
			this.button_master_3.Name = "button_master_3";
			this.button_master_3.Size = new System.Drawing.Size(53, 23);
			this.button_master_3.TabIndex = 11;
			this.button_master_3.Text = "(3)";
			this.button_master_3.UseVisualStyleBackColor = true;
			this.button_master_3.Click += new System.EventHandler(this.button_master3_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 관ToolStripMenuItem
			// 
			this.관ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용자로그ToolStripMenuItem,
            this.메뉴관리ToolStripMenuItem});
			this.관ToolStripMenuItem.Name = "관ToolStripMenuItem";
			this.관ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.관ToolStripMenuItem.Text = "관리자";
			// 
			// 사용자로그ToolStripMenuItem
			// 
			this.사용자로그ToolStripMenuItem.Name = "사용자로그ToolStripMenuItem";
			this.사용자로그ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.사용자로그ToolStripMenuItem.Text = "사용자 로그";
			this.사용자로그ToolStripMenuItem.Click += new System.EventHandler(this.사용자로그ToolStripMenuItem_Click);
			// 
			// 메뉴관리ToolStripMenuItem
			// 
			this.메뉴관리ToolStripMenuItem.Name = "메뉴관리ToolStripMenuItem";
			this.메뉴관리ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.메뉴관리ToolStripMenuItem.Text = "메뉴관리";
			this.메뉴관리ToolStripMenuItem.Click += new System.EventHandler(this.메뉴관리ToolStripMenuItem_Click);
			// 
			// button_order
			// 
			this.button_order.Location = new System.Drawing.Point(616, 18);
			this.button_order.Name = "button_order";
			this.button_order.Size = new System.Drawing.Size(75, 23);
			this.button_order.TabIndex = 11;
			this.button_order.Text = "주문하기";
			this.button_order.UseVisualStyleBackColor = true;
			this.button_order.Click += new System.EventHandler(this.button_order_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 474);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonLogout);
			this.Controls.Add(this.labelmaster);
			this.Name = "MainForm";
			this.Text = "맛있는 커피";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_master)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelmaster;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.GroupBox groupBox_master;
		private System.Windows.Forms.DataGridView dataGridView_master;
		private System.Windows.Forms.Button button_master_1;
		private System.Windows.Forms.Button button_master_2;
		private System.Windows.Forms.Button button_master_3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 관ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 사용자로그ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 메뉴관리ToolStripMenuItem;
		private System.Windows.Forms.Button button_order_search;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Button button_order;
	}
}

