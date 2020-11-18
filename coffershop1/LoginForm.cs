using System;
using System.Windows.Forms;

namespace coffershop1
{
	public partial class LoginForm : Form
	{

		private LoginAccount la;

		public LoginForm()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				la = DBManager.GetInstance().Login(textBoxID.Text, textBoxPW.Text);

				if(la.master.Equals("0"))
				DBManager.GetInstance().Login_Log(la);

				MessageBox.Show(la.name + "님 반갑습니다.", "Hello!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				this.Hide();
				MainForm form = new MainForm(la);
				form.Show();

				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Cursor = Cursors.Default;
			}
		}

		private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			System.Diagnostics.Process.GetCurrentProcess().Kill();
		}
	}
}
