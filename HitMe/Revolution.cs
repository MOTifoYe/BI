using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitMe
{
    public partial class Revolution : Form
    {
        Player orfin = new Player("Orfin");
        
        public Revolution()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) => TextUpdate();

        private void label1_Click(object sender, EventArgs e) => TextUpdate();

        private void button1_Click(object sender, EventArgs e)
        {
            orfin.Hit();
            TextUpdate();
        }

        private void TextUpdate()
        {
            label1.Text = orfin.GetHealth().ToString();
            button1.Text = orfin.GetDamage().ToString();
        }

    }
}
