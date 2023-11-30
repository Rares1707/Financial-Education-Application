using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       public void hidemenu()
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
        }
        public void showFaBanii()
        {
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            panel1.Show();
            panel2.Show();
            panel3.Show();
            button7.Show();
            button8.Show();
            button9.Show();
        }
        public void showCheltuie()
        {
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            panel4.Show();
            panel5.Show();
            panel6.Show();
            button10.Show();
            button11.Show();
            button12.Show();

        }
        public void showSalveaza()
        {
            label11.Show(); label12.Show(); label13.Show(); label14.Show(); label15.Show();
            panel7.Show(); panel8.Show(); panel9.Show();
            button13.Show(); button14.Show(); button15.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            hidemenu();
            showFaBanii();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            antreprenor1.Visible = false;
            lucru1.Visible = false;
            schimbvalutar1.Visible = false;
            personalitati_Si_Bancnote1.Visible = false;
            sfaturi1.Visible = false;
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide(); panel7.Hide(); panel8.Hide(); panel9.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            dobanda1.Visible = false;
            button12.Hide(); button13.Hide(); button14.Hide(); button15.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            hidemenu();
            showCheltuie();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            hidemenu();
            showSalveaza();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sfaturi1.Visible = true;
            hidemenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            personalitati_Si_Bancnote1.Visible = true;
            personalitati_Si_Bancnote1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dobanda1.Visible = true;
            hidemenu();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            lucru1.Visible = true;
            lucru1.BringToFront();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            schimbvalutar1.Visible = true;
            schimbvalutar1.BringToFront();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            dobanda1.Visible = true;
            dobanda1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            antreprenor1.Visible = true;
            antreprenor1.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bancnotetest1.Visible = true;
            bancnotetest1.BringToFront();
        }
    }
}
