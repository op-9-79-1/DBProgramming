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
	public partial class MenuManager : Form
	{
		DataSet data_set;
		public MenuManager()
		{
			InitializeComponent();
			MM_Load();
		}

		private void button_revise_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			DataTable dtChanges = new DataTable();
			DataTable dtProcessFlag = (DataTable)dataGridView_Menu.DataSource;

			dtChanges = dtProcessFlag.GetChanges(DataRowState.Modified);

			DBManager.GetInstance().coffee_Modify(dtChanges);

			MM_Load();

			this.Cursor = Cursors.Default;
		}

		private void button_plus_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			DataTable dtChanges = new DataTable();
			DataTable dtProcessFlag = (DataTable)dataGridView_Menu.DataSource;

			dtChanges = dtProcessFlag.GetChanges(DataRowState.Added);

			DBManager.GetInstance().coffee_Modify(dtChanges);

			MM_Load();

			this.Cursor = Cursors.Default;
		}

		private void button_Refresh_Click(object sender, EventArgs e)
		{
			MM_Load();
		}

		private void MM_Load()
		{
			try
			{
				data_set = DBManager.GetInstance().coffee_select();

				dataGridView_Menu.DataSource = data_set.Tables[0];

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
