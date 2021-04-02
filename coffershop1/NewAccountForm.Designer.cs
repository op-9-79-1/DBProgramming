namespace coffershop1
{
	partial class NewAccountForm
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
			this.button_create = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_pw = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_id = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button_create
			// 
			this.button_create.Location = new System.Drawing.Point(169, 170);
			this.button_create.Name = "button_create";
			this.button_create.Size = new System.Drawing.Size(75, 23);
			this.button_create.TabIndex = 18;
			this.button_create.Text = "가입";
			this.button_create.UseVisualStyleBackColor = true;
			this.button_create.Click += new System.EventHandler(this.button_create_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(112, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 12);
			this.label2.TabIndex = 17;
			this.label2.Text = "PW";
			// 
			// textBox_pw
			// 
			this.textBox_pw.Location = new System.Drawing.Point(156, 122);
			this.textBox_pw.Name = "textBox_pw";
			this.textBox_pw.Size = new System.Drawing.Size(116, 21);
			this.textBox_pw.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(112, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 12);
			this.label1.TabIndex = 15;
			this.label1.Text = "ID";
			// 
			// textBox_id
			// 
			this.textBox_id.Location = new System.Drawing.Point(156, 79);
			this.textBox_id.Name = "textBox_id";
			this.textBox_id.Size = new System.Drawing.Size(116, 21);
			this.textBox_id.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(112, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 12);
			this.label3.TabIndex = 20;
			this.label3.Text = "Name";
			// 
			// textBox_name
			// 
			this.textBox_name.Location = new System.Drawing.Point(156, 40);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(116, 21);
			this.textBox_name.TabIndex = 19;
			// 
			// NewAccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 273);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_name);
			this.Controls.Add(this.button_create);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_pw);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_id);
			this.Name = "NewAccountForm";
			this.Text = "NewAccountForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_create;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_pw;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_id;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_name;
	}
}