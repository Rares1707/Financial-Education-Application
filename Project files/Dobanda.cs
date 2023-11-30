using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinal
{
    public partial class Dobanda : UserControl
    {
        public Dobanda()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /* double val = Int32.Parse(textBox2.Text) * (Int32.Parse(textBox1.Text) * 5.61 / 100) / 365;
             label4.Text = "Pentru aceasta depunere, primiti o dobanda de " + val.ToString("0") + " RON"; */
            double val = Int32.Parse(textBox1.Text);
            label12.Text = (val + val * 5/100 / 12).ToString("0");
            label13.Text = (val + val * 5/100 / 6).ToString("0");
            label14.Text = (val + val * 5/100 / 2).ToString("0");
            label15.Text = (val + val * 5/100).ToString("0");
            label16.Text = (val + val * 5/100*2).ToString("0");
            label17.Text = (val + val * 5*5/100).ToString("0");
            label18.Text = (val + val * 5/10).ToString("0");
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
