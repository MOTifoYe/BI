using System;
using System.Windows.Forms;

namespace Generator

{
    public partial class Form1 : Form
    {
        char[] lower = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
        char[] upper = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };
        char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] wek;
        Random random = new Random(Convert.ToInt32(DateTime.Now.Millisecond));

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            wek = new char[70];
            int wekLen = 0;
            if (lowerCase.Checked)
            {
                lower.CopyTo(wek, wekLen);
                wekLen += lower.Length;
            }
            if (upperCase.Checked)
            {
                upper.CopyTo(wek, wekLen);
                wekLen += upper.Length;
            }
            if (numberCase.Checked)
            {
                numbers.CopyTo(wek, wekLen);
                wekLen += numbers.Length;
            }

            try
            {
                int length = Convert.ToInt32(textBox2.Text);

                for (int i = 0; i < length; i++)
                {
                    textBox.Text += wek[random.Next(wekLen)];
                }
            }
            catch (System.FormatException)
            {

            }


        }
    }
}
