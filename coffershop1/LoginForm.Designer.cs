namespace coffershop1
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonLogin = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPW = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.button_newaccount = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(112, 177);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(75, 23);
			this.buttonLogin.TabIndex = 13;
			this.buttonLogin.Text = "로그인";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(110, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 12);
			this.label2.TabIndex = 12;
			this.label2.Text = "PW";
			// 
			// textBoxPW
			// 
			this.textBoxPW.Location = new System.Drawing.Point(154, 129);
			this.textBoxPW.Name = "textBoxPW";
			this.textBoxPW.Size = new System.Drawing.Size(116, 21);
			this.textBoxPW.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(110, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 12);
			this.label1.TabIndex = 10;
			this.label1.Text = "ID";
			// 
			// textBoxID
			// 
			this.textBoxID.Location = new System.Drawing.Point(154, 86);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(116, 21);
			this.textBoxID.TabIndex = 9;
			// 
			// button_newaccount
			// 
			this.button_newaccount.Location = new System.Drawing.Point(195, 177);
			this.button_newaccount.Name = "button_newaccount";
			this.button_newaccount.Size = new System.Drawing.Size(75, 23);
			this.button_newaccount.TabIndex = 14;
			this.button_newaccount.Text = "유저 등록";
			this.button_newaccount.UseVisualStyleBackColor = true;
			this.button_newaccount.Click += new System.EventHandler(this.button_newaccount_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 321);
			this.Controls.Add(this.button_newaccount);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPW);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxID);
			this.Name = "LoginForm";
			this.Text = "로그인";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPW;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.Button button_newaccount;
	}
}