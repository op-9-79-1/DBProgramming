using System;
using System.Data;
using System.Windows.Forms;

namespace coffershop1
{
	public partial class MainForm : Form
	{
		public LoginAccount la;
		
		public MainForm()
		{
			InitializeComponent();
		}

		public MainForm(LoginAccount la)
		{
			this.la = la;
			InitializeComponent();
			labelmaster.Text = la.name + "님 안녕하세요.";

			if (la.master == "1")
			{
				this.Controls.Add(this.button_master_3);
				this.Controls.Add(this.button_master_2);
				this.Controls.Add(this.button_master_1);
				this.Controls.Add(this.groupBox_master);
				this.groupBox_master.Controls.Add(this.dataGridView_master);
				this.Controls.Add(this.menuStrip1);
			}
			else
			{
				insert_coffee_flp1();
				insert_coffee_flp2();
			}
		}

		private void buttonLogout_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				labelmaster.Text = "로그인 대기중.";

				if (la.master.Equals("0"))
					DBManager.GetInstance().Logout_Log(la);
				MessageBox.Show("로그아웃 되었습니다.", "로그아웃", MessageBoxButtons.OK, MessageBoxIcon.Information);

				this.Hide();
				LoginForm loginForm = new LoginForm();
				loginForm.Show();

				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void button_master1_Click(object sender, EventArgs e)
		{
			DataTable account = DBManager.GetInstance().Load1_Table(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
			dataGridView_master.DataSource = account;
		}

		private void button_master2_Click(object sender, EventArgs e)
		{
			DataTable account = DBManager.GetInstance().Load2_Table(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
			dataGridView_master.DataSource = account;
		}

		private void button_master3_Click(object sender, EventArgs e)
		{
			DataTable account = DBManager.GetInstance().Load3_Table(dateTimePicker1.Value.ToString("yyyy-MM"));
			dataGridView_master.DataSource = account;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (la.master.Equals("0"))
				DBManager.GetInstance().Logout_Log(la);
			System.Diagnostics.Process.GetCurrentProcess().Kill();
		}

		private void 사용자로그ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UserLog userLog = new UserLog();
			userLog.Show();
		}

		private void 메뉴관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MenuManager menuManager = new MenuManager();
			menuManager.Show();
		}

		private void button_order_search_Click(object sender, EventArgs e)
		{
			OrderSearch Os = new OrderSearch(la.id, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
			Os.Show();
		}

		private void insert_coffee_flp1()
		{
			ListBox listBox = DBManager.GetInstance().coffee_name();

			foreach (var i in listBox.Items)
			{
				Button button = new Button();
				button.Text = i.ToString();
				button.Size = new System.Drawing.Size(90, 50);
				button.Name = i.ToString() + "button";
				button.Parent = this;
				button.Tag = listBox.Items.IndexOf(i);
				button.Click += new EventHandler(button_insert_coffee);
				flowLayoutPanel1.Controls.Add(button);
			}
		}

		private void button_insert_coffee(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			DBManager.GetInstance().Insert_coffee(la, (int)btn.Tag + 1, dateTimePicker1.Value.ToString("yyyy-MM-dd HH시 mm분"));
		}

		private void insert_coffee_flp2()
		{
			ListBox listBox = DBManager.GetInstance().coffee_name();

			foreach (var i in listBox.Items)
			{
				Button button = new Button();
				button.Text = i.ToString();
				button.Size = new System.Drawing.Size(60, 50);
				button.Name = "button_" + i.ToString();
				button.Parent = this;
				button.MouseUp += button_insert_coffee_ver2;


				Label label = new Label();
				label.Name = i.ToString() + "label";
				label.Tag = 0;
				label.Text = " 카운터 : " + label.Tag.ToString();
				
				flowLayoutPanel2.Controls.Add(button);
				flowLayoutPanel2.Controls.Add(label);

				button.Tag = label;
			}
		}
		private void button_insert_coffee_ver2(object sender, EventArgs e)
		{
			MouseEventArgs e_e = (MouseEventArgs)e;
			if (e_e.Button == MouseButtons.Left)
			{
				Button btn = sender as Button;
				Label lb = btn.Tag as Label;

				int clickcount = (int)lb.Tag;
				clickcount++;
				lb.Text = " 카운터 : " + clickcount.ToString();
				lb.Tag = clickcount;
			}
			if (e_e.Button == MouseButtons.Right)
			{
				Button btn = sender as Button;
				Label lb = btn.Tag as Label;

				int clickcount = (int)lb.Tag;
				if (clickcount == 0)
				{
					MessageBox.Show("0미만으로 낮출 수 없습니다.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				clickcount--;
				lb.Text = " 카운터 : " + clickcount.ToString();
				lb.Tag = clickcount;
			}
		}

		private void button_order_Click(object sender, EventArgs e)
		{
			ListBox listBox = DBManager.GetInstance().coffee_name();

			foreach (var i in listBox.Items)
			{
			}
		}
	}
}
