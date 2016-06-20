using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Glavnay : Form
    {
        public Glavnay()
        {
           InitializeComponent();
        }
                private void button3_Click(object sender, EventArgs e)
        {
            Hide(); 
            Algiritm1 A1  = new Algiritm1();
            //Exeption
           A1.ShowDialog();
            Close(); 
        }
                private void button1_Click(object sender, EventArgs e)
        {
            HELP H = new HELP();
            H.ShowDialog();
                
        }
                private void button2_Click(object sender, EventArgs e)
        {
            O_nas O = new O_nas();
            O.ShowDialog();
        }
                private void button10_Click(object sender, EventArgs e)
        {
            Histori Hi = new Histori();
            Hi.ShowDialog();
        }
                private void button4_Click(object sender, EventArgs e)
        {                        Hide();
            Algiritm2 A2 = new Algiritm2();
            A2.ShowDialog();
        }
                private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Algiritm3 A3 = new Algiritm3();
            A3.ShowDialog();
        }
                private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Algiritm4 A4 = new Algiritm4();
            A4.ShowDialog();
        }
                private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Algiritm4 A4 = new Algiritm4();
            A4.ShowDialog();
            Close();
        }
                private void Glavnay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
                private void groupBox1_Enter(object sender, EventArgs e)
        { 
        }
                private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.MediumSpringGreen;

        }
                private void Glavnay_MouseHover(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Aquamarine;
            groupBox2.BackColor = Color.Aquamarine;
            groupBox3.BackColor = Color.Aquamarine;
            groupBox4.BackColor = Color.Aquamarine;
        }
                private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
                private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            groupBox2.BackColor = Color.MediumSpringGreen;
        }
                private void groupBox3_MouseHover(object sender, EventArgs e)
        {
            groupBox3.BackColor = Color.MediumSpringGreen;
        }
                private void groupBox4_MouseHover(object sender, EventArgs e)
        {
            groupBox4.BackColor = Color.MediumSpringGreen;
        }
                private void Glavnay_MouseMove(object sender, MouseEventArgs e)
        {
            groupBox1.BackColor = Color.Aquamarine;
            groupBox2.BackColor = Color.Aquamarine;
            groupBox3.BackColor = Color.Aquamarine;
            groupBox4.BackColor = Color.Aquamarine;
        }
                private void groupBox2_Move(object sender, EventArgs e)
        {
            groupBox2.BackColor = Color.MediumSpringGreen;
        }
                private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            groupBox1.BackColor = Color.MediumSpringGreen;
        }
                private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            groupBox2.BackColor = Color.MediumSpringGreen;
        }
                private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            groupBox3.BackColor = Color.MediumSpringGreen;
        }
               private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            groupBox4.BackColor = Color.MediumSpringGreen;
        }

        private void groupBox1_Move(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.MediumSpringGreen;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Move(object sender, EventArgs e)
        {
            groupBox3.BackColor = Color.MediumSpringGreen;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Move(object sender, EventArgs e)
        {
            groupBox4.BackColor = Color.MediumSpringGreen;
        }
    }
}
