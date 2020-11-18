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
	public partial class UserLog : Form
	{
		DataTable table = new DataTable();
		public UserLog()
		{
			InitializeComponent();
			show_Log();
		}

		public void show_Log()
		{
			table = DBManager.GetInstance().show_login_log();
			dataGridView1.DataSource = table;
		}
	}
}
