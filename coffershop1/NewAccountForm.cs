using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffershop1
{
	public partial class NewAccountForm : Form
	{
		public NewAccountForm()
		{
			InitializeComponent();
		}

		private void button_create_Click(object sender, EventArgs e)
		{
			DBManager.GetInstance().new_account(textBox_name.Text, textBox_id.Text, textBox_pw.Text);
			MessageBox.Show("생성되었습니다", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Close();
		}
	}
}
