using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectV3
{
    public partial class Personalitati_Si_Bancnote : UserControl
    {
        public Personalitati_Si_Bancnote()
        {
            InitializeComponent();
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                label1.Visible = false;
                label10.Visible = false;

                pictureBox2.Visible = true;
                label2.Visible = true;
                label20.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                label2.Visible = false;
                label20.Visible = false;

                pictureBox3.Visible = true;
                label3.Visible = true;
                label30.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                label3.Visible = false;
                label30.Visible = false;

                pictureBox4.Visible = true;
                label4.Visible = true;
                label40.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                label4.Visible = false;
                label40.Visible = false;

                pictureBox5.Visible = true;
                label5.Visible = true;
                label50.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                label5.Visible = false;
                label50.Visible = false;

                pictureBox6.Visible = true;
                label6.Visible = true;
                label60.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                label6.Visible = false;
                label60.Visible = false;

                pictureBox7.Visible = true;
                label7.Visible = true;
                label70.Visible = true;
            }
            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                label7.Visible = false;
                label70.Visible = false;

                pictureBox8.Visible = true;
                label8.Visible = true;
                label80.Visible = true;
            }
            else if (pictureBox8.Visible == true)
            {
                pictureBox8.Visible = false;
                label8.Visible = false;
                label80.Visible = false;

                pictureBox1.Visible = true;
                label1.Visible = true;
                label10.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                label1.Visible = false;
                label10.Visible = false;

                pictureBox8.Visible = true;
                label8.Visible = true;
                label80.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                label2.Visible = false;
                label20.Visible = false;

                pictureBox1.Visible = true;
                label1.Visible = true;
                label10.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                label3.Visible = false;
                label30.Visible = false;

                pictureBox2.Visible = true;
                label2.Visible = true;
                label20.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                label4.Visible = false;
                label40.Visible = false;

                pictureBox3.Visible = true;
                label3.Visible = true;
                label30.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                label5.Visible = false;
                label50.Visible = false;

                pictureBox4.Visible = true;
                label4.Visible = true;
                label40.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                label6.Visible = false;
                label60.Visible = false;

                pictureBox5.Visible = true;
                label5.Visible = true;
                label50.Visible = true;
            }
            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                label7.Visible = false;
                label70.Visible = false;

                pictureBox6.Visible = true;
                label6.Visible = true;
                label60.Visible = true;
            }
            else if (pictureBox8.Visible == true)
            {
                pictureBox8.Visible = false;
                label8.Visible = false;
                label80.Visible = false;

                pictureBox7.Visible = true;
                label7.Visible = true;
                label70.Visible = true;
            }
        }
    }
}
