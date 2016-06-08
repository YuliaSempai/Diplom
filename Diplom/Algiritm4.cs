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
    public partial class Algiritm4 : Form
    {
        public Algiritm4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random RandomClass = new Random();
            int num1, num2, num3, num4, num5, num6;
            num1 = RandomClass.Next(1, 49);
            num2 = RandomClass.Next(1, 49);
            num3 = RandomClass.Next(1, 49);
            num4 = RandomClass.Next(1, 49);
            num5 = RandomClass.Next(1, 49);
            num6 = RandomClass.Next(1, 49);

            textBox1.Text = num1.ToString();
            textBox2.Text = num2.ToString();
            textBox3.Text = num3.ToString();
            textBox4.Text = num4.ToString();
            textBox5.Text = num5.ToString();
            textBox6.Text = num6.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Histori4 Hi4 = new Histori4();
            Hi4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HELP4 H4 = new HELP4();
            H4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Glavnay G = new Glavnay();
            G.Show();
        }

        private void Algiritm4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
