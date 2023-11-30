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
    public partial class antreprenor : UserControl
    {
        public antreprenor()
        {
            InitializeComponent();
        }
        private void button_WOC1_Click(object sender, EventArgs e)
        {
        }

        int punctaj = 0;
        private void button_WOC2_Click(object sender, EventArgs e)
        {


        }

        private void antreprenor_Load(object sender, EventArgs e)
        {
            button_WOC2.Visible = false;
            labelfinal.Visible = false;
        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button_WOC1.Visible = false;

            lbl_Intrebare1.Visible = true;
            lbl_Intrebare2.Visible = true;
            lbl_Intrebare3.Visible = true;
            lbl_Intrebare4.Visible = true;
            lbl_Intrebare5.Visible = true;
            lbl_Intrebare6.Visible = true;

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            groupBox6.Visible = true;

            button_WOC2.Visible = true;
        }

        private void button_WOC2_Click_1(object sender, EventArgs e)
        {
            labelfinal.Visible = true;
            if (radioButton2.Checked)
                punctaj += 3;
            else if (radioButton3.Checked)
                punctaj += 2;
            else if (radioButton4.Checked)
                punctaj += 1;

            if (radioButton9.Checked)
                punctaj += 3;
            else if (radioButton10.Checked)
                punctaj += 1;
            else if (radioButton12.Checked)
                punctaj += 1;

            if (radioButton19.Checked)
                punctaj += 2;
            else if (radioButton18.Checked)
                punctaj += 2;

            if (radioButton8.Checked)
                punctaj += 3;
            else if (radioButton6.Checked)
                punctaj += 1;

            if (radioButton13.Checked)
                punctaj += 1;
            else if (radioButton14.Checked)
                punctaj += 3;
            else if (radioButton15.Checked)
                punctaj += 3;

            if (radioButton23.Checked)
                punctaj += 2;

            lbl_Intrebare1.Visible = false;
            lbl_Intrebare2.Visible = false;
            lbl_Intrebare3.Visible = false;
            lbl_Intrebare4.Visible = false;
            lbl_Intrebare5.Visible = false;
            lbl_Intrebare6.Visible = false;

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;

            button_WOC2.Visible = false;

            label4.Text = "Ai obtinut " + punctaj.ToString() + " puncte din 16! \n Persistența este cheia! Antreprenorii sunt motivați, \n au abilități de planificare și organizare și au \n noi idei  bune.Dacă intentionezi să fii propriul tau șef, \n cauta modalități de îmbunătățire a calitatilor tale acum \n, cum ar fi începerea propriului proiect scolar sau sa inveti \n cum să economisesti bani.Gandeste - te la lucrurile la care esti bun și care iti \n plac. Ai putea să gasesti niște idei foarte bune de afaceri în acest fel.";
            label4.Visible = true;
            label4.BringToFront();
            labelfinal.Visible = true;
            labelfinal.Visible = true;
            labelfinal.BringToFront();
        }
    }
}
