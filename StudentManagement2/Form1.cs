using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagement2
{
	public partial class Form1 : Form
	{
		string strConn = "Server=49.50.174.201;Database=s5414441;Uid=s5414441;Pwd=s5414441;Charset=utf8"; //db 설정

		public Form1()
		{
			InitializeComponent();
			isChecked(); // 체크박스 체크 확인
		}

		private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
		{
			loadstudent(); // 불러오기 메소드 부르기
		}

		private void loadstudent() //불러오기 메소드
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
						textBoxStudentMemo1.Text = rdr["memo"].ToString();
					}
					else if (rdr["id"].ToString() == "2")
					{
						textBoxStudentName2.Text = rdr["name"].ToString();
						textBoxStudentNum2.Text = rdr["stn"].ToString();
						comboBoxStudentGender2.SelectedIndex = Convert.ToInt32(rdr["gender"]);
						textBoxStudentMemo2.Text = rdr["memo"].ToString();
					}
					else if (rdr["id"].ToString() == "3")
					{
						textBoxStudentName3.Text = rdr["name"].ToString();
						textBoxStudentNum3.Text = rdr["stn"].ToString();
						comboBoxStudentGender3.SelectedIndex = Convert.ToInt32(rdr["gender"]);
						textBoxStudentMemo3.Text = rdr["memo"].ToString();
					}
				}

				checkingStudent(); // 저장된 학생 수 
				rdr.Close();
			}
		}

		private void buttonStudent1Save_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(strConn))
			{
				conn.Open();
				MySqlCommand cmdname = new MySqlCommand("UPDATE student SET name = '" + textBoxStudentName1.Text + "' WHERE id = 1", conn); // 데이터 갱신을 위해 update 사용
				MySqlCommand cmdstn = new MySqlCommand("UPDATE student SET stn = '" + textBoxStudentNum1.Text + "' WHERE id = 1", conn);
				MySqlCommand cmdgender = new MySqlCommand("UPDATE student SET gender = '" + comboBoxStudentGender1.SelectedIndex + "' WHERE id = 1", conn);
				MySqlCommand cmdmemo = new MySqlCommand("UPDATE student SET memo = '" + textBoxStudentMemo1.Text + "' WHERE id = 1", conn);
				cmdname.ExecuteNonQuery();
				cmdstn.ExecuteNonQuery();
				cmdgender.ExecuteNonQuery();
				cmdmemo.ExecuteNonQuery();

				checkingStudent();
				conn.Close();
			}
		}

		private void buttonStudent2Save_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(strConn))
			{
				conn.Open();

				MySqlCommand cmdname = new MySqlCommand("UPDATE student SET name = '" + textBoxStudentName2.Text + "' WHERE id = 2", conn); // 데이터 갱신을 위해 update 사용
				MySqlCommand cmdstn = new MySqlCommand("UPDATE student SET stn = '" + textBoxStudentNum2.Text + "' WHERE id = 2", conn);
				MySqlCommand cmdgender = new MySqlCommand("UPDATE student SET gender = '" + comboBoxStudentGender2.SelectedIndex + "' WHERE id = 2", conn);
				MySqlCommand cmdmemo = new MySqlCommand("UPDATE student SET memo = '" + textBoxStudentMemo2.Text + "' WHERE id = 2", conn);
				cmdname.ExecuteNonQuery();
				cmdstn.ExecuteNonQuery();
				cmdgender.ExecuteNonQuery();
				cmdmemo.ExecuteNonQuery();

				checkingStudent();
				conn.Close();
			}
		}

		private void buttonStudent3Save_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(strConn))
			{
				conn.Open();

				MySqlCommand cmdname = new MySqlCommand("UPDATE student SET name = '" + textBoxStudentName3.Text + "' WHERE id = 3", conn); // 데이터 갱신을 위해 update 사용
				MySqlCommand cmdstn = new MySqlCommand("UPDATE student SET stn = '" + textBoxStudentNum3.Text + "' WHERE id = 3", conn);
				MySqlCommand cmdgender = new MySqlCommand("UPDATE student SET gender = '" + comboBoxStudentGender3.SelectedIndex + "' WHERE id = 3", conn);
				MySqlCommand cmdmemo = new MySqlCommand("UPDATE student SET memo = '" + textBoxStudentMemo3.Text + "' WHERE id = 3", conn);
				cmdname.ExecuteNonQuery();
				cmdstn.ExecuteNonQuery();
				cmdgender.ExecuteNonQuery();
				cmdmemo.ExecuteNonQuery();

				checkingStudent();
				conn.Close();
			}


		}
		private void checkingStudent()
		{
			int sum = 3; // DB에서 따로 추출해도 되지만 좀 더 쉽게 접근

			if (textBoxStudentName1.Text == "" || textBoxStudentNum1.Text == "" || textBoxStudentMemo1.Text == "")
				sum--;

			if (textBoxStudentName2.Text == "" || textBoxStudentNum2.Text == "" || textBoxStudentMemo2.Text == "")
				sum--;

			if (textBoxStudentName3.Text == "" || textBoxStudentNum3.Text == "" || textBoxStudentMemo3.Text == "")
				sum--;
			labelCheckStudent.Text = "현재 저장된 학생 수 :" + sum;

		}

		private void buttonStudentDel1_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(strConn))
			{
				conn.Open();

				MySqlCommand cmd = new MySqlCommand("DELETE FROM student WHERE id = 1", conn); // 데이터를 지우는 DELETE를 사용해 id를 조건으로 삭제
				MySqlCommand cmdinsert = new MySqlCommand("INSERT INTO student(id) values ('1')", conn); // 삭제 후 id가 1이 아닌 3 이상이 나오는걸 방지
				MySqlCommand cmdgender = new MySqlCommand("UPDATE student SET gender = '0' WHERE id = 1", conn); // gender값이 index 이기에 공백이면 오류떠서 0으로 설정
				cmd.ExecuteNonQuery();
				cmdinsert.ExecuteNonQuery();
				cmdgender.ExecuteNonQuery();

				textBoxStudentName1.Text = ""; // 삭제 후 적혀진 필드 모두 초기화
				textBoxStudentNum1.Text = "";
				comboBoxStudentGender1.Text = "";
				textBoxStudentMemo1.Text = "";

				checkingStudent();
				conn.Close();
			}

		}

		private void buttonStudentDel2_Click(object sender, EventArgs e)
		{

			using (MySqlConnection conn = new MySqlConnection(strConn))
			{
				conn.Open();

				MySqlCommand cmd = new MySqlCommand("DELETE FROM student WHERE id = 2", conn);
				MySqlCommand cmdinsert = new MySqlCommand("INSERT INTO student(id) values ('2')", conn);
				MySqlCommand cmdgender = new MySqlCommand("UPDATE student SET gender = '0' WHERE id = 2", conn);
				cmd.ExecuteNonQuery();
				cmdinsert.ExecuteNonQuery();
				cmdgender.ExecuteNonQuery();

				textBoxStudentName2.Text = "";
				textBoxStudentNum2.Text = "";
				comboBoxStudentGender2.Text = "";
				textBoxStudentMemo2.Text = "";

				checkingStudent();
				conn.Close();
			}
		}

		private void buttonStudentDel3_Click(object sender, EventArgs e)
		{

			using (MySqlConnection conn = new MySqlConnection(strConn))
			{
				conn.Open();

				MySqlCommand cmd = new MySqlCommand("DELETE FROM student WHERE id = 3", conn);
				MySqlCommand cmdinsert = new MySqlCommand("INSERT INTO student(id) values ('3')", conn);
				MySqlCommand cmdgender = new MySqlCommand("UPDATE student SET gender = '0' WHERE id = 3", conn);
				cmd.ExecuteNonQuery();
				cmdinsert.ExecuteNonQuery();
				cmdgender.ExecuteNonQuery();

				textBoxStudentName3.Text = "";
				textBoxStudentNum3.Text = "";
				comboBoxStudentGender3.Text = "";
				textBoxStudentMemo3.Text = "";

				checkingStudent();
				conn.Close();
			}
		}
		private void isChecked()
		{
			if (checkBox1.Checked) // 체크되었을 경우 true
			{
				loadstudent();
			}

		}
	}
}
