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
    public partial class Lucru : UserControl
    {
        public Lucru()
        {
            InitializeComponent();
        }
        int venit, pret, timp, zile;

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                venit = 20;
            else if (radioButton2.Checked)
                venit = 23;
            else if (radioButton3.Checked)
                venit = 45;
            else if (radioButton4.Checked)
                venit = Convert.ToInt32(textBox1.Text);

            if (radioButton5.Checked)
                pret = 300;
            else if (radioButton6.Checked)
                pret = 180;
            else if (radioButton7.Checked)
                pret = 2000;
            else if (radioButton8.Checked)
                pret = Convert.ToInt32(textBox2.Text);
            label6.Text = venit.ToString();
            venit = venit * 24;
            zile = pret / venit;
            int rest = pret % venit;
            int ore = rest / (venit / 24);
            label6.Text = "Va trebui sa lucrezi ";
            if (zile != 0 && ore != 0)
                label6.Text = label6.Text + zile.ToString() + " zile si " + ore.ToString() + " ore pentru a cumpara ceea ce doresti.";
            else if (zile != 0)
                label6.Text = label6.Text + zile.ToString() + " zile pentru a cumpara ceea ce doresti.";
            else if (ore != 0)
                label6.Text = label6.Text + ore.ToString() + " ore pentru a cumpara ceea ce doresti.";
        }
    }
}
