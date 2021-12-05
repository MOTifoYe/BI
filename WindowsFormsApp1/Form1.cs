using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ControlBox = !ControlBox;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ShowInTaskbar = !ShowInTaskbar;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			TopMost = !TopMost;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string t = "Border style";
			string t1 = "None";
			string t2 = "Sizable";

			FormBorderStyle = FormBorderStyle == FormBorderStyle.Sizable ? FormBorderStyle.None : FormBorderStyle.Sizable;
			button4.Text = button4.Text == $"{t}\n{t2}" ? $"{t}\n{t1}" : $"{t}\n{t2}";
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			button4.Text = "Border style\nSizable";
			
		}
    }
}
