using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagement3
{
	public partial class MainForm : Form
	{
		string strConn = "Server=49.50.174.201;Database=s5414441;Uid=s5414441;Pwd=s5414441;Charset=utf8"; //db 설정


		public MainForm()
		{
			InitializeComponent();
			isChecked(); // 체크박스 체크 확인
		}

		private void isChecked()

		{
			if (checkBox1.Checked) // 체크되었을 경우 true
			{
				loadstudent();
			}

			if (checkBox2.Checked)
			{
				loadmajorlist();
				RecentMajor();
			}
		}

		private void loadmajorlist()
		{

			listBoxmajor.Items.Clear();

			using (MySqlConnection conn = new MySqlConnection(strConn))
			{
				conn.Open();

				string query = "select * from major ";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				MySqlDataReader rdr = cmd.ExecuteReader(); // 저장된 데이터 읽기

				while (rdr.Read())
				{
					listBoxmajor.Items.Add(rdr["major"].ToString());
				}
			}
		}

		private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
		{
			loadstudent();
		}

		public void loadstudent()
		{
			using (MySqlConnection conn = new MySqlConnection(strConn))
			{
				conn.Open();

				string query = "select * from student"; // 모든 데이터 저장
				MySqlCommand cmd = new MySqlCommand(query, conn);
				MySqlDataReader rdr = cmd.ExecuteReader(); // 저장된 데이터 읽기

				while (rdr.Read()) // row로 한줄씩
				{
					if (rdr["id"].ToString() == "1") // id를 1 2 3 으로 저장했기에 rdr가 읽어낸 id에 조건붙여 넣기
					{
						textBoxStudentName1.Text = rdr["name"].ToString();
						textBoxStudentNum1.Text = rdr["stn"].ToString();
						comboBoxStudentGender1.SelectedIndex = Convert.ToInt32(rdr["gender"]);
					}
					else if (rdr["id"].ToString() == "2")
					{
						textBoxStudentName2.Text = rdr["name"].ToString();
						textBoxStudentNum2.Text = rdr["stn"].ToString();
						comboBoxStudentGender2.SelectedIndex = Convert.ToInt32(rdr["gender"]);
					}
					else if (rdr["id"].ToString() == "3")
					{
						textBoxStudentName3.Text = rdr["name"].ToString();
						textBoxStudentNum3.Text = rdr["stn"].ToString();
						comboBoxStudentGender3.SelectedIndex = Convert.ToInt32(rdr["gender"]);
					}
				}
				rdr.Close();
			}
		}

		private void buttonMajorSave_Click(object sender, EventArgs e)
		{
			DBManager.GetInstance().Insert_A_Update("INSERT INTO major(major) values ('" + textBoxMajorInsert.Text + "')");
			loadmajorlist();
		}

		private void buttonStudent1Save_Click(object sender, EventArgs e)
		{
			DBManager.GetInstance().Insert_A_Update("UPDATE student SET name = '" + textBoxStudentName1.Text + "' WHERE id = 1");
			DBManager.GetInstance().Insert_A_Update("UPDATE student SET stn = '" + textBoxStudentNum1.Text + "' WHERE id = 1");
			DBManager.GetInstance().Insert_A_Update("UPDATE student SET gender = '" + comboBoxStudentGender1.SelectedIndex + "' WHERE id = 1");
		}

		private void buttonStudent2Save_Click(object sender, EventArgs e)
		{
			DBManager.GetInstance().Insert_A_Update("UPDATE student SET name = '" + textBoxStudentName2.Text + "' WHERE id = 1");
			DBManager.GetInstance().Insert_A_Update("UPDATE student SET stn = '" + textBoxStudentNum2.Text + "' WHERE id = 1");
			DBManager.GetInstance().Insert_A_Update("UPDATE student SET gender = '" + comboBoxStudentGender2.SelectedIndex + "' WHERE id = 1");
		}

		private void buttonStudent3Save_Click(object sender, EventArgs e)
		{
			DBManager.GetInstance().Insert_A_Update("UPDATE student SET name = '" + textBoxStudentName3.Text + "' WHERE id = 1");
			DBManager.GetInstance().Insert_A_Update("UPDATE student SET stn = '" + textBoxStudentNum3.Text + "' WHERE id = 1");
			DBManager.GetInstance().Insert_A_Update("UPDATE student SET gender = '" + comboBoxStudentGender3.SelectedIndex + "' WHERE id = 1");
		}

		private void buttonStudentDel1_Click(object sender, EventArgs e)
		{
			DBManager.GetInstance().Insert_A_Update("DELETE FROM student WHERE id = 1");
			DBManager.GetInstance().Insert_A_Update("INSERT INTO student(id) values ('1')");
			DBManager.GetInstance().Insert_A_Update("UPDATE student SET gender = '0' WHERE id = 1");

			Student1_Clear();
		}
		private void Student1_Clear()
		{
			textBoxStudentName1.Text = ""; // 삭제 후 적혀진 필드 모두 초기화
			textBoxStudentNum1.Text = "";
			comboBoxStudentGender1.Text = "";
		}
		private void buttonStudentDel2_Click(object sender, EventArgs e)
		{
			DBManager.GetInstance().Insert_A_Update("DELETE FROM student WHERE id = 2");
			DBManager.GetInstance().Insert_A_Update("INSERT INTO student(id) values ('2')");
			DBManager.GetInstance().Insert_A_Update("UPDATE student SET gender = '0' WHERE id = 2");

			Student2_Clear();
		}

		private void Student2_Clear()
		{
			textBoxStudentName2.Text = "";
			textBoxStudentNum2.Text = "";
			comboBoxStudentGender2.Text = "";
		}

		private void buttonStudentDel3_Click(object sender, EventArgs e)
		{
			DBManager.GetInstance().Insert_A_Update("DELETE FROM student WHERE id = 3");
			DBManager.GetInstance().Insert_A_Update("INSERT INTO student(id) values ('3')");
			DBManager.GetInstance().Insert_A_Update("UPDATE student SET gender = '3' WHERE id = 3");

			Student3_Clear();
		}

		private void Student3_Clear()
		{
			textBoxStudentName3.Text = "";
			textBoxStudentNum3.Text = "";
			comboBoxStudentGender3.Text = "";
		}

		private void checkBox_CheckedChanged(object sender, EventArgs e)
		{
			//Properties.Settings.Default.Save();
		}

		private void listBoxmajor_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			int count = 0;
			Properties.Settings.Default.index_set = listBoxmajor.SelectedIndex;
			Properties.Settings.Default.Save();

			if (listBoxmajor.SelectedItems.Count == 1)
			{
				String major = listBoxmajor.SelectedItem.ToString();

				
				using (MySqlConnection conn = new MySqlConnection(strConn))
				{
					conn.Open();

					string query = "select * from student WHERE major = '" + major + "'"; // 모든 데이터 저장
					MySqlCommand cmd = new MySqlCommand(query, conn);
					MySqlDataReader rdr = cmd.ExecuteReader(); // 저장된 데이터 읽기

					Student1_Clear();
					Student2_Clear();
					Student3_Clear();

					while (rdr.Read()) // row로 한줄씩
					{
						if (count == 0)
						{
							textBoxStudentName1.Text = rdr["name"].ToString();
							textBoxStudentNum1.Text = rdr["stn"].ToString();
							comboBoxStudentGender1.SelectedIndex = Convert.ToInt32(rdr["gender"]);
							count++;
							continue;
						}

						else if (count == 1)
						{
							textBoxStudentName2.Text = rdr["name"].ToString();
							textBoxStudentNum2.Text = rdr["stn"].ToString();
							comboBoxStudentGender2.SelectedIndex = Convert.ToInt32(rdr["gender"]);
							count++;
							continue;
						}
						else if (count == 2)
						{
							textBoxStudentName3.Text = rdr["name"].ToString();
							textBoxStudentNum3.Text = rdr["stn"].ToString();
							comboBoxStudentGender3.SelectedIndex = Convert.ToInt32(rdr["gender"]);
							break;
						}
					}
					rdr.Close();
				}
			}
		}
		private void RecentMajor()
		{
			//int index = ConfigManager.GetInstance().GetRecentlyUsedListIdx();
			listBoxmajor.SetSelected(3, true);
		}
	}
}
