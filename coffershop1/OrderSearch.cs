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
	public partial class OrderSearch : Form
	{
		DataSet ds;
		private string time_value;
		private string id;
		public OrderSearch()
		{
			InitializeComponent();
		}

		public OrderSearch(string id, string time)
		{
			InitializeComponent();

			this.time_value = time;
			this.id = id;
			show_Log();
		}

		public void show_Log()
		{
			ds = DBManager.GetInstance().order_select(id, time_value);
			dataGridView_Menu.DataSource = ds.Tables[0];
		}

		private void button_revise_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			DataTable dtChanges = new DataTable();
			DataTable dtProcessFlag = (DataTable)dataGridView_Menu.DataSource;

			dtChanges = dtProcessFlag.GetChanges(DataRowState.Modified);

			DBManager.GetInstance().order_Modify(dtChanges, id, time_value);

			show_Log();

			this.Cursor = Cursors.Default;
		}

		private void button_del_Click(object sender, EventArgs e)
		{
			int rowIndex = dataGridView_Menu.CurrentRow.Index;

			dataGridView_Menu.Rows[rowIndex].Cells[3].Value = "취소됨";
			
			this.Cursor = Cursors.WaitCursor;

			DataTable dtChanges = new DataTable();
			DataTable dtProcessFlag = (DataTable)dataGridView_Menu.DataSource;


			dtProcessFlag.Rows[rowIndex].SetModified();

			dataGridView_Menu.Rows[rowIndex].Cells[3].Value = "취소됨";

			dtChanges = dtProcessFlag.GetChanges(DataRowState.Modified);

			DBManager.GetInstance().order_Modify(dtChanges, id, time_value);

			show_Log();

			this.Cursor = Cursors.Default;
		}

		private void button_Refresh_Click(object sender, EventArgs e)
		{
			show_Log();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			ds = DBManager.GetInstance().order_select_time(id, time_value, dateTimePicker1.Value.ToString("HH시 mm분"));
			dataGridView_Menu.DataSource = ds.Tables[0];
		}
	}
}
