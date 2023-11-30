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
    public partial class Schimbvalutar : UserControl
    {
        public Schimbvalutar()
        {
            InitializeComponent();
        }
        public void Convert(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                textBox2.Text = textBox1.Text;
            }
            else if (x == 0 && y == 1)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 0.23573;
            }
            else if (x == 0 && y == 2)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 0.210562025;
            }
            else if (x == 0 && y == 3)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 0.179106858;
            }
            else if (x == 0 && y == 4)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 26.2004222;
            }
            else if (x == 1 && y == 0)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 4.24034262;
            }
            else if (x == 1 && y == 1)
            {
                textBox2.Text = textBox1.Text;
            }
            else if (x == 1 && y == 2)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 0.89267382;
            }
            else if (x == 1 && y == 3)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 0.759474444;
            }
            else if (x == 1 && y == 4)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 111.098767;
            }
            else if (x == 2 && y == 0)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 4.75061477;
            }
            else if (x == 2 && y == 1)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 1.12048;
            }
            else if (x == 2 && y == 2)
            {
                textBox2.Text = textBox1.Text;
            }
            else if (x == 2 && y == 3)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 0.850759471;
            }
            else if (x == 2 && y == 4)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 124.483946;
            }
            else if (x == 3 && y == 0)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 5.5839693;
            }
            else if (x == 3 && y == 1)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 1.317035;
            }
            else if (x == 3 && y == 2)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 1.17542036;
            }
            else if (x == 3 && y == 3)
            {
                textBox2.Text = textBox1.Text;
            }
            else if (x == 3 && y == 4)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 146.320964;
            }
            else if (x == 4 && y == 0)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 0.0381549941;
            }
            else if (x == 4 && y == 1)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 0.009;
            }
            else if (x == 4 && y == 2)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 0.00803248695;
            }
            else if (x == 4 && y == 3)
            {
                textBox2.Text = "" + Int32.Parse(textBox1.Text) * 0.00683217224;
            }
            else if (x == 4 && y == 4)
            {
                textBox2.Text = textBox2.Text;
            }


        }

        private void schimbvalutar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = comboBox1.SelectedIndex;
            int y = comboBox2.SelectedIndex;
            Convert(x, y);
        }
    }
}
