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
				listBox_coffee_init();
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

		private void listBox_coffee_init()
		{
			listBox_coffee.Items.Clear();
			ListBox listBox = DBManager.GetInstance().coffee_name();

			foreach (var i in listBox.Items)
				listBox_coffee.Items.Add(i);
		}

		private void button_insert_coffee_Click(object sender, EventArgs e)
		{
			int idx = listBox_coffee.SelectedIndex;

			try
			{
				this.Cursor = Cursors.WaitCursor;
				DBManager.GetInstance().Insert_coffee(la, (idx + 1), dateTimePicker1.Value.ToString("yyyy-MM-dd HH시 mm분"));
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button_order_search_Click(object sender, EventArgs e)
		{
			OrderSearch Os = new OrderSearch(la.id, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
			Os.Show();
		}
	}
}
