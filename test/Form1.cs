using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.Load += DynamicButton_Load;
		}

		public void DynamicButton_Load(object sender, EventArgs e)
		{
			DynamicButton();
		}

		public void DynamicButton()
		{
			Control[] BTN = new Control[10];
			FlowLayoutPanel flp = new FlowLayoutPanel();

			for (int idx = 0; idx < 10; idx++)
			{
				BTN[idx] = new Button();
				BTN[idx].Name = idx.ToString();
				BTN[idx].Parent = this;
				BTN[idx].Location = new System.Drawing.Point(100, idx * 100 + 100);
				BTN[idx].Size = new Size(100, 100);

				int x = idx + 1;
				BTN[idx].Text = "Dynamic_" + x.ToString();

				flp.Controls.Add(BTN[idx]);
			}

			this.Controls.Add(flp);
			flp.Dock = DockStyle.Fill;
		}
	}
}
