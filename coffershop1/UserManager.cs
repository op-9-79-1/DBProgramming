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
	public partial class UserManager : Form
	{
		DataSet data_set;
		public UserManager()
		{
			InitializeComponent();
			UM_load();
		}

		private void UM_load()
		{
			try
			{
				data_set = DBManager.GetInstance().user_select();

				dataGridView_Menu.DataSource = data_set.Tables[0];

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button_plus_Click(object sender, EventArgs e)
		{
			int rowIndex = dataGridView_Menu.CurrentRow.Index;

			dataGridView_Menu.Rows[rowIndex].Cells[3].Value = null;

			this.Cursor = Cursors.WaitCursor;

			DataTable dtChanges = new DataTable();
			DataTable dtProcessFlag = (DataTable)dataGridView_Menu.DataSource;


			dtProcessFlag.Rows[rowIndex].SetModified();

			dataGridView_Menu.Rows[rowIndex].Cells[3].Value = null;

			dtChanges = dtProcessFlag.GetChanges(DataRowState.Modified);

			DBManager.GetInstance().user_Modify(dtChanges);

			UM_load();

			this.Cursor = Cursors.Default;
		}

		private void button_del_Click(object sender, EventArgs e)
		{
			int rowIndex = dataGridView_Menu.CurrentRow.Index;

			dataGridView_Menu.Rows[rowIndex].Cells[3].Value = "제한";

			this.Cursor = Cursors.WaitCursor;

			DataTable dtChanges = new DataTable();
			DataTable dtProcessFlag = (DataTable)dataGridView_Menu.DataSource;


			dtProcessFlag.Rows[rowIndex].SetModified();

			dataGridView_Menu.Rows[rowIndex].Cells[3].Value = "제한";

			dtChanges = dtProcessFlag.GetChanges(DataRowState.Modified);

			DBManager.GetInstance().user_Modify(dtChanges);

			UM_load();

			this.Cursor = Cursors.Default;
		}

		private void button_Refresh_Click(object sender, EventArgs e)
		{
			UM_load();
		}
	}
}
