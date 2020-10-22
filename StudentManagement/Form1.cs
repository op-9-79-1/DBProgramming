using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
	public partial class Form1 : Form
	{
		private bool loadCompleted_ = false;
		public Form1()
		{
			InitializeComponent();
			isChecked();
		}

		private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
		{
			loadStudent();
			loadCompleted_ = true;
		}

		#region Student1 Event Handlers
		private void buttonStudent1Save_Click(object sender, EventArgs e)
		{
			studentSave();
		}

		private void textBoxStudentName1_TextChanged(object sender, EventArgs e)
		{
			studentSave();
		}

		private void textBoxStudentNum1_TextChanged(object sender, EventArgs e)
		{
			studentSave();
		}

		private void comboBoxStudentGender1_SelectedIndexChanged(object sender, EventArgs e)
		{
			studentSave();
		}

		private void textBoxStudentMemo1_TextChanged(object sender, EventArgs e)
		{
			studentSave();
		}

		private void buttonStudentDel1_Click(object sender, EventArgs e)
		{
			textBoxStudentName1.Text = "";
			textBoxStudentNum1.Text = "";
			comboBoxStudentGender1.Text = "";
			textBoxStudentMemo1.Text = "";

			studentSave();
		}
		#endregion

		#region Student2 Event Handlers
		private void buttonStudent2Save_Click(object sender, EventArgs e)
		{
			studentSave();
		}

		private void textBoxStudentName2_TextChanged(object sender, EventArgs e)
		{
			studentSave();
		}

		private void textBoxStudentNum2_TextChanged(object sender, EventArgs e)
		{
			studentSave();
		}

		private void comboBoxStudentGender2_SelectedIndexChanged(object sender, EventArgs e)
		{
			studentSave();
		}

		private void textBoxStudentMemo2_TextChanged(object sender, EventArgs e)
		{
			studentSave();
		}

		private void buttonStudentDel2_Click(object sender, EventArgs e)
		{
			textBoxStudentName2.Text = "";
			textBoxStudentNum2.Text = "";
			comboBoxStudentGender2.Text = "";
			textBoxStudentMemo2.Text = "";

			studentSave();
		}
		#endregion

		#region Student3 Event handlers
		private void buttonStudent3Save_Click(object sender, EventArgs e)
		{
			studentSave();
		}
		private void textBoxStudentName3_TextChanged(object sender, EventArgs e)
		{
			studentSave();
		}

		private void textBoxStudentNum3_TextChanged(object sender, EventArgs e)
		{
			studentSave();
		}

		private void comboBoxStudentGender3_SelectedIndexChanged(object sender, EventArgs e)
		{
			studentSave();
		}

		private void textBoxStudentMemo3_TextChanged(object sender, EventArgs e)
		{
			studentSave();
		}

		private void buttonStudentDel3_Click(object sender, EventArgs e)
		{
			textBoxStudentName3.Text = "";
			textBoxStudentNum3.Text = "";
			comboBoxStudentGender3.Text = "";
			textBoxStudentMemo3.Text = "";

			studentSave();

		}
		#endregion

		private void studentSave()
		{
			if (loadCompleted_ == false)
				return;
			
			BinaryWriter bw = new BinaryWriter(new FileStream("student.won", FileMode.Create));

			bw.Write(textBoxStudentName1.Text);
			bw.Write(textBoxStudentNum1.Text);
			bw.Write(Convert.ToInt32(comboBoxStudentGender1.SelectedIndex));
			bw.Write(textBoxStudentMemo1.Text);
		
			bw.Write(textBoxStudentName2.Text);
			bw.Write(textBoxStudentNum2.Text);
			bw.Write(Convert.ToInt32(comboBoxStudentGender2.SelectedIndex));
			bw.Write(textBoxStudentMemo2.Text);
	
			bw.Write(textBoxStudentName3.Text);
			bw.Write(textBoxStudentNum3.Text);
			bw.Write(Convert.ToInt32(comboBoxStudentGender3.SelectedIndex));
			bw.Write(textBoxStudentMemo3.Text);

			bw.Close();

			checkingStudent();
		}

		private void loadStudent()
		{
			BinaryReader br = new BinaryReader(new FileStream("student.won", FileMode.Open));


			textBoxStudentName1.Text = br.ReadString();
			textBoxStudentNum1.Text = br.ReadString();
			comboBoxStudentGender1.SelectedIndex = br.ReadInt32();
			textBoxStudentMemo1.Text = br.ReadString();

			textBoxStudentName2.Text = br.ReadString();
			textBoxStudentNum2.Text = br.ReadString();
			comboBoxStudentGender2.SelectedIndex = br.ReadInt32();
			textBoxStudentMemo2.Text = br.ReadString();

			textBoxStudentName3.Text = br.ReadString();
			textBoxStudentNum3.Text = br.ReadString();
			comboBoxStudentGender3.SelectedIndex = br.ReadInt32();
			textBoxStudentMemo3.Text = br.ReadString();

			br.Close();

			checkingStudent();
		}

		private void isChecked()
		{
			if (checkBox1.Checked)
			{
				loadStudent();
				loadCompleted_ = true;
			}

		}

		private void checkingStudent()
		{
			int sum = 3;

			if (textBoxStudentName1.Text == "" || textBoxStudentNum1.Text == "" || textBoxStudentMemo1.Text == "")
				sum--;

			if (textBoxStudentName2.Text == "" || textBoxStudentNum2.Text == "" || textBoxStudentMemo2.Text == "")
				sum--;

			if (textBoxStudentName3.Text == "" || textBoxStudentNum3.Text == "" || textBoxStudentMemo3.Text == "")
				sum--;

			labelCheckStudent.Text = "현재 저장된 학생 수 :" + sum;
		}
	}
}
