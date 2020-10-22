namespace StudentManagement
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonLoadStudentInfo = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonStudentDel1 = new System.Windows.Forms.Button();
			this.textBoxStudentMemo1 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.buttonStudent1Save = new System.Windows.Forms.Button();
			this.comboBoxStudentGender1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxStudentNum1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxStudentName1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonStudentDel2 = new System.Windows.Forms.Button();
			this.textBoxStudentMemo2 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.buttonStudent2Save = new System.Windows.Forms.Button();
			this.comboBoxStudentGender2 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxStudentNum2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxStudentName2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonStudentDel3 = new System.Windows.Forms.Button();
			this.textBoxStudentMemo3 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.buttonStudent3Save = new System.Windows.Forms.Button();
			this.comboBoxStudentGender3 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxStudentNum3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxStudentName3 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.labelCheckStudent = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonLoadStudentInfo
			// 
			this.buttonLoadStudentInfo.Location = new System.Drawing.Point(12, 12);
			this.buttonLoadStudentInfo.Name = "buttonLoadStudentInfo";
			this.buttonLoadStudentInfo.Size = new System.Drawing.Size(183, 79);
			this.buttonLoadStudentInfo.TabIndex = 0;
			this.buttonLoadStudentInfo.Text = "학생정보 불러오기";
			this.buttonLoadStudentInfo.UseVisualStyleBackColor = true;
			this.buttonLoadStudentInfo.Click += new System.EventHandler(this.buttonLoadStudentInfo_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonStudentDel1);
			this.groupBox1.Controls.Add(this.textBoxStudentMemo1);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.buttonStudent1Save);
			this.groupBox1.Controls.Add(this.comboBoxStudentGender1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBoxStudentNum1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBoxStudentName1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(41, 97);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(202, 341);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "학생1";
			// 
			// buttonStudentDel1
			// 
			this.buttonStudentDel1.Location = new System.Drawing.Point(6, 287);
			this.buttonStudentDel1.Name = "buttonStudentDel1";
			this.buttonStudentDel1.Size = new System.Drawing.Size(190, 37);
			this.buttonStudentDel1.TabIndex = 9;
			this.buttonStudentDel1.Text = "삭제";
			this.buttonStudentDel1.UseVisualStyleBackColor = true;
			this.buttonStudentDel1.Click += new System.EventHandler(this.buttonStudentDel1_Click);
			// 
			// textBoxStudentMemo1
			// 
			this.textBoxStudentMemo1.Location = new System.Drawing.Point(88, 146);
			this.textBoxStudentMemo1.Multiline = true;
			this.textBoxStudentMemo1.Name = "textBoxStudentMemo1";
			this.textBoxStudentMemo1.Size = new System.Drawing.Size(100, 92);
			this.textBoxStudentMemo1.TabIndex = 8;
			this.textBoxStudentMemo1.TextChanged += new System.EventHandler(this.textBoxStudentMemo1_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(26, 146);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 12);
			this.label10.TabIndex = 7;
			this.label10.Text = "메모";
			// 
			// buttonStudent1Save
			// 
			this.buttonStudent1Save.Location = new System.Drawing.Point(6, 244);
			this.buttonStudent1Save.Name = "buttonStudent1Save";
			this.buttonStudent1Save.Size = new System.Drawing.Size(190, 37);
			this.buttonStudent1Save.TabIndex = 6;
			this.buttonStudent1Save.Text = "저장";
			this.buttonStudent1Save.UseVisualStyleBackColor = true;
			this.buttonStudent1Save.Click += new System.EventHandler(this.buttonStudent1Save_Click);
			// 
			// comboBoxStudentGender1
			// 
			this.comboBoxStudentGender1.FormattingEnabled = true;
			this.comboBoxStudentGender1.Items.AddRange(new object[] {
            "남자",
            "여자"});
			this.comboBoxStudentGender1.Location = new System.Drawing.Point(88, 114);
			this.comboBoxStudentGender1.Name = "comboBoxStudentGender1";
			this.comboBoxStudentGender1.Size = new System.Drawing.Size(100, 20);
			this.comboBoxStudentGender1.TabIndex = 5;
			this.comboBoxStudentGender1.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentGender1_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "성별";
			// 
			// textBoxStudentNum1
			// 
			this.textBoxStudentNum1.Location = new System.Drawing.Point(88, 73);
			this.textBoxStudentNum1.Name = "textBoxStudentNum1";
			this.textBoxStudentNum1.Size = new System.Drawing.Size(100, 21);
			this.textBoxStudentNum1.TabIndex = 3;
			this.textBoxStudentNum1.TextChanged += new System.EventHandler(this.textBoxStudentNum1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "학번";
			// 
			// textBoxStudentName1
			// 
			this.textBoxStudentName1.Location = new System.Drawing.Point(88, 31);
			this.textBoxStudentName1.Name = "textBoxStudentName1";
			this.textBoxStudentName1.Size = new System.Drawing.Size(100, 21);
			this.textBoxStudentName1.TabIndex = 1;
			this.textBoxStudentName1.Text = "학생 정보 없음";
			this.textBoxStudentName1.TextChanged += new System.EventHandler(this.textBoxStudentName1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "이름";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonStudentDel2);
			this.groupBox2.Controls.Add(this.textBoxStudentMemo2);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.buttonStudent2Save);
			this.groupBox2.Controls.Add(this.comboBoxStudentGender2);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBoxStudentNum2);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBoxStudentName2);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(291, 97);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(202, 341);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "학생2";
			// 
			// buttonStudentDel2
			// 
			this.buttonStudentDel2.Location = new System.Drawing.Point(6, 287);
			this.buttonStudentDel2.Name = "buttonStudentDel2";
			this.buttonStudentDel2.Size = new System.Drawing.Size(190, 37);
			this.buttonStudentDel2.TabIndex = 10;
			this.buttonStudentDel2.Text = "삭제";
			this.buttonStudentDel2.UseVisualStyleBackColor = true;
			this.buttonStudentDel2.Click += new System.EventHandler(this.buttonStudentDel2_Click);
			// 
			// textBoxStudentMemo2
			// 
			this.textBoxStudentMemo2.Location = new System.Drawing.Point(88, 146);
			this.textBoxStudentMemo2.Multiline = true;
			this.textBoxStudentMemo2.Name = "textBoxStudentMemo2";
			this.textBoxStudentMemo2.Size = new System.Drawing.Size(100, 92);
			this.textBoxStudentMemo2.TabIndex = 9;
			this.textBoxStudentMemo2.TextChanged += new System.EventHandler(this.textBoxStudentMemo2_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(26, 146);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 12);
			this.label11.TabIndex = 7;
			this.label11.Text = "메모";
			// 
			// buttonStudent2Save
			// 
			this.buttonStudent2Save.Location = new System.Drawing.Point(6, 244);
			this.buttonStudent2Save.Name = "buttonStudent2Save";
			this.buttonStudent2Save.Size = new System.Drawing.Size(190, 37);
			this.buttonStudent2Save.TabIndex = 6;
			this.buttonStudent2Save.Text = "저장";
			this.buttonStudent2Save.UseVisualStyleBackColor = true;
			this.buttonStudent2Save.Click += new System.EventHandler(this.buttonStudent2Save_Click);
			// 
			// comboBoxStudentGender2
			// 
			this.comboBoxStudentGender2.FormattingEnabled = true;
			this.comboBoxStudentGender2.Items.AddRange(new object[] {
            "남자",
            "여자"});
			this.comboBoxStudentGender2.Location = new System.Drawing.Point(88, 114);
			this.comboBoxStudentGender2.Name = "comboBoxStudentGender2";
			this.comboBoxStudentGender2.Size = new System.Drawing.Size(100, 20);
			this.comboBoxStudentGender2.TabIndex = 5;
			this.comboBoxStudentGender2.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentGender2_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 4;
			this.label4.Text = "성별";
			// 
			// textBoxStudentNum2
			// 
			this.textBoxStudentNum2.Location = new System.Drawing.Point(88, 73);
			this.textBoxStudentNum2.Name = "textBoxStudentNum2";
			this.textBoxStudentNum2.Size = new System.Drawing.Size(100, 21);
			this.textBoxStudentNum2.TabIndex = 3;
			this.textBoxStudentNum2.TextChanged += new System.EventHandler(this.textBoxStudentNum2_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(26, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 2;
			this.label5.Text = "학번";
			// 
			// textBoxStudentName2
			// 
			this.textBoxStudentName2.Location = new System.Drawing.Point(88, 31);
			this.textBoxStudentName2.Name = "textBoxStudentName2";
			this.textBoxStudentName2.Size = new System.Drawing.Size(100, 21);
			this.textBoxStudentName2.TabIndex = 1;
			this.textBoxStudentName2.Text = "학생 정보 없음";
			this.textBoxStudentName2.TextChanged += new System.EventHandler(this.textBoxStudentName2_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(26, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 12);
			this.label6.TabIndex = 0;
			this.label6.Text = "이름";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.buttonStudentDel3);
			this.groupBox3.Controls.Add(this.textBoxStudentMemo3);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.buttonStudent3Save);
			this.groupBox3.Controls.Add(this.comboBoxStudentGender3);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.textBoxStudentNum3);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.textBoxStudentName3);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Location = new System.Drawing.Point(546, 97);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(202, 341);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "학생3";
			// 
			// buttonStudentDel3
			// 
			this.buttonStudentDel3.Location = new System.Drawing.Point(6, 287);
			this.buttonStudentDel3.Name = "buttonStudentDel3";
			this.buttonStudentDel3.Size = new System.Drawing.Size(190, 37);
			this.buttonStudentDel3.TabIndex = 10;
			this.buttonStudentDel3.Text = "삭제";
			this.buttonStudentDel3.UseVisualStyleBackColor = true;
			this.buttonStudentDel3.Click += new System.EventHandler(this.buttonStudentDel3_Click);
			// 
			// textBoxStudentMemo3
			// 
			this.textBoxStudentMemo3.Location = new System.Drawing.Point(88, 143);
			this.textBoxStudentMemo3.Multiline = true;
			this.textBoxStudentMemo3.Name = "textBoxStudentMemo3";
			this.textBoxStudentMemo3.Size = new System.Drawing.Size(100, 92);
			this.textBoxStudentMemo3.TabIndex = 9;
			this.textBoxStudentMemo3.TextChanged += new System.EventHandler(this.textBoxStudentMemo3_TextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(26, 146);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(29, 12);
			this.label12.TabIndex = 7;
			this.label12.Text = "메모";
			// 
			// buttonStudent3Save
			// 
			this.buttonStudent3Save.Location = new System.Drawing.Point(6, 244);
			this.buttonStudent3Save.Name = "buttonStudent3Save";
			this.buttonStudent3Save.Size = new System.Drawing.Size(190, 37);
			this.buttonStudent3Save.TabIndex = 6;
			this.buttonStudent3Save.Text = "저장";
			this.buttonStudent3Save.UseVisualStyleBackColor = true;
			this.buttonStudent3Save.Click += new System.EventHandler(this.buttonStudent3Save_Click);
			// 
			// comboBoxStudentGender3
			// 
			this.comboBoxStudentGender3.FormattingEnabled = true;
			this.comboBoxStudentGender3.Items.AddRange(new object[] {
            "남자",
            "여자"});
			this.comboBoxStudentGender3.Location = new System.Drawing.Point(88, 114);
			this.comboBoxStudentGender3.Name = "comboBoxStudentGender3";
			this.comboBoxStudentGender3.Size = new System.Drawing.Size(100, 20);
			this.comboBoxStudentGender3.TabIndex = 5;
			this.comboBoxStudentGender3.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentGender3_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(26, 114);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 12);
			this.label7.TabIndex = 4;
			this.label7.Text = "성별";
			// 
			// textBoxStudentNum3
			// 
			this.textBoxStudentNum3.Location = new System.Drawing.Point(88, 73);
			this.textBoxStudentNum3.Name = "textBoxStudentNum3";
			this.textBoxStudentNum3.Size = new System.Drawing.Size(100, 21);
			this.textBoxStudentNum3.TabIndex = 3;
			this.textBoxStudentNum3.TextChanged += new System.EventHandler(this.textBoxStudentNum3_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(26, 73);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 2;
			this.label8.Text = "학번";
			// 
			// textBoxStudentName3
			// 
			this.textBoxStudentName3.Location = new System.Drawing.Point(88, 31);
			this.textBoxStudentName3.Name = "textBoxStudentName3";
			this.textBoxStudentName3.Size = new System.Drawing.Size(100, 21);
			this.textBoxStudentName3.TabIndex = 1;
			this.textBoxStudentName3.Text = "학생 정보 없음";
			this.textBoxStudentName3.TextChanged += new System.EventHandler(this.textBoxStudentName3_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(26, 31);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(29, 12);
			this.label9.TabIndex = 0;
			this.label9.Text = "이름";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.labelCheckStudent);
			this.groupBox4.Controls.Add(this.checkBox1);
			this.groupBox4.Location = new System.Drawing.Point(258, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(385, 79);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "설정 및 정보";
			// 
			// labelCheckStudent
			// 
			this.labelCheckStudent.AutoSize = true;
			this.labelCheckStudent.Location = new System.Drawing.Point(37, 51);
			this.labelCheckStudent.Name = "labelCheckStudent";
			this.labelCheckStudent.Size = new System.Drawing.Size(121, 12);
			this.labelCheckStudent.TabIndex = 1;
			this.labelCheckStudent.Text = "현재 저장된 학생 수 :";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(39, 20);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(244, 16);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "프로그램 시작시 자동으로 학생정보 로드";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonLoadStudentInfo);
			this.Name = "Form1";
			this.Text = "학생정보관리 프로그램";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonLoadStudentInfo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxStudentName1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonStudent1Save;
		private System.Windows.Forms.ComboBox comboBoxStudentGender1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxStudentNum1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonStudent2Save;
		private System.Windows.Forms.ComboBox comboBoxStudentGender2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxStudentNum2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxStudentName2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button buttonStudent3Save;
		private System.Windows.Forms.ComboBox comboBoxStudentGender3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxStudentNum3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxStudentName3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button buttonStudentDel1;
		private System.Windows.Forms.TextBox textBoxStudentMemo1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button buttonStudentDel2;
		private System.Windows.Forms.TextBox textBoxStudentMemo2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button buttonStudentDel3;
		private System.Windows.Forms.TextBox textBoxStudentMemo3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label labelCheckStudent;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}

