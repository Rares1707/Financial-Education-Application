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
    public partial class Bancnotetest : UserControl
    {
        public Bancnotetest()
        {
            InitializeComponent();
        }
        int scor = 0, faza=1;

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Bancnotetest_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (faza == 1)
            {
                if (radioButton2.Checked)
                {
                    groupBox8.Visible = false;
                    scor++;
                    pictureBox7.SendToBack();
                    faza++;
                    groupBox1.Visible = true;
                }
                else
                {
                    groupBox8.Visible = false;
                    pictureBox7.Hide();
                    groupBox1.Visible = true;
                    faza++;
                }
            }
            else if (faza == 2)
            {
                groupBox1.Show();
                if (radioButton6.Checked)
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                    pictureBox6.Hide();
                    faza++;
                    scor++;
                }
                else
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                    pictureBox6.Hide();
                    faza++;
                }
            }
            else if (faza == 3)
            {
                if (radioButton12.Checked)
                {
                    groupBox2.Visible = false;
                    groupBox3.Visible = true;
                    pictureBox5.Hide();
                    faza++;
                    scor++;
                }
                else
                {
                    groupBox2.Visible = false;
                    groupBox3.Visible = true;
                    pictureBox5.Hide();
                    faza++;
                }
            }
            else if (faza == 4)
            {
                if (radioButton15.Checked)
                {
                    groupBox3.Visible = false;
                    groupBox4.Visible = true;
                    pictureBox4.Hide();
                    faza++;
                    scor++;
                }
                else
                {
                    groupBox3.Visible = false;
                    groupBox4.Visible = true;
                    pictureBox4.Hide();
                    faza++;
                }
            }
            else if (faza == 5)
            {
                if (radioButton20.Checked)
                {
                    groupBox4.Visible = false;
                    groupBox5.Visible = true;
                    pictureBox3.Hide();
                    faza++;
                    scor++;
                }
                else
                {
                    groupBox4.Visible = false;
                    groupBox5.Visible = true;
                    pictureBox3.Hide();
                    faza++;
                }
            }
            else if (faza == 6)
            {
                if (radioButton22.Checked)
                {
                    groupBox5.Visible = false;
                    groupBox6.Visible = true;
                    pictureBox2.Hide();
                    faza++;
                    scor++;
                }
                else
                {
                    groupBox5.Visible = false;
                    groupBox6.Visible = true;
                    pictureBox2.SendToBack();
                    faza++;
                }
            }
            else if(faza == 7)
            {
                if(radioButton25.Checked)
                {
                    groupBox6.Visible = false;
                    pictureBox1.Hide();
                    groupBox6.Hide();
                    scor++;
                    faza++;
                    label1.Text = label1.Text + scor.ToString() + "din cele 7 bancnote";
                    label1.Visible = true;
                    button1.Visible = false;
                }
                else
                {
                    groupBox6.Visible = false;
                    pictureBox1.Hide();
                    groupBox6.Hide();
                    faza++;
                    label1.Text = label1.Text+ ' ' + scor.ToString() + " din cele 7 bancnote.";
                    label1.Visible = true;
                    button1.Visible = false;
                }
            }      
        }    
    }
}

