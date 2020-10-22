using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		string strConn = "Server=49.50.174.201;Database=s5414441;Uid=s5414441;Pwd=s5414441;Charset=utf8";

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(strConn))
			{
				conn.Open();

				string query = "INSERT INTO student(name,gender) values ('박길동','남자') ";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.ExecuteNonQuery();
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(strConn)) {
				conn.Open();

				string query = "select * from student";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				MySqlDataReader rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{
					string str = rdr["id"] + " " + rdr["name"] + " " + rdr["gender"];
					MessageBox.Show(str);
				}

				rdr.Close();


			}
		}
	}
}
