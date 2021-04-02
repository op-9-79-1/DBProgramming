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
		DialogResult result;
		public Form1()
		{
			InitializeComponent();
			do
			{
				result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
			}
			while (
				result == DialogResult.Retry
			);
			
		}

	}
}
