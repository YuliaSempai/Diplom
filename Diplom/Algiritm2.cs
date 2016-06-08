using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Diplom
{
    public partial class Algiritm2 : Form
    {
        public Algiritm2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 3;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 14)
                e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 3;

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 13)
                e.Handled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 3;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 3;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 3;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.MaxLength = 3;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.MaxLength = 3;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            HELP2 H2 = new HELP2();
            H2.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Glavnay G = new Glavnay();
            G.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Histori2 Hi2 = new Histori2();
            Hi2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
            label7.Text = null;
            label8.Text = null;
            label9.Text = null;
            label10.Text = null;
            label11.Text = null;
            label12.Text = null;
            label13.Text = null;
            label14.Text = null;
            label15.Text = null;
            label16.Text = null;
            label17.Text = null;
            label18.Text = null;
            label19.Text = null;
            label20.Text = null;
            label21.Text = null;
            label22.Text = null;
            label23.Text = null;
            label24.Text = null;
            label25.Text = null;
            label26.Text = null;
            label27.Text = null;
            label28.Text = null;
            label29.Text = null;
            label30.Text = null;
            label31.Text = null;
            label32.Text = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random RandomClass = new Random();
            int num1, num2, num3, num4, num5, num6, num7, num8;
            num1 = RandomClass.Next(1, 49);
            num2 = RandomClass.Next(1, 49);
            num3 = RandomClass.Next(1, 49);
            num4 = RandomClass.Next(1, 49);
            num5 = RandomClass.Next(1, 49);
            num6 = RandomClass.Next(1, 49);
            num7 = RandomClass.Next(1, 49);
            num8 = RandomClass.Next(1, 49);

            textBox1.Text = num1.ToString();
            textBox2.Text = num2.ToString();
            textBox3.Text = num3.ToString();
            textBox4.Text = num4.ToString();
            textBox5.Text = num5.ToString();
            textBox6.Text = num6.ToString();
            textBox7.Text = num5.ToString();
            textBox8.Text = num6.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 7)
                e.Handled = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox1.Text))
                label1.Text = "0";
            else label1.Text = textBox1.Text;
            if (String.IsNullOrEmpty(textBox2.Text))
                label2.Text = "0";
            else label2.Text = textBox2.Text;
            if (String.IsNullOrEmpty(textBox3.Text))
                label3.Text = "0";
            else label3.Text = textBox3.Text;
            if (String.IsNullOrEmpty(textBox4.Text))
                label4.Text = "0";
            else label4.Text = textBox4.Text;
            if (String.IsNullOrEmpty(textBox5.Text))
                label5.Text = "0";
            else label5.Text = textBox5.Text;
            if (String.IsNullOrEmpty(textBox6.Text))
                label6.Text = "0";
            else label6.Text = textBox6.Text;
            if (String.IsNullOrEmpty(textBox7.Text))
                label7.Text = "0";
            else label7.Text = textBox7.Text;
            if (String.IsNullOrEmpty(textBox8.Text))
                label8.Text = "0";
            else label8.Text = textBox8.Text;
            //
            label1.BackColor = Color.Aqua;
            await Task.Delay(500);
            label1.BackColor = Color.Transparent;
            int L1 = Convert.ToInt32(label1.Text);
            
            int L2 = Convert.ToInt32(label2.Text);
            label2.BackColor = Color.Aqua;
            await Task.Delay(500);
            label2.BackColor = Color.Transparent;
            int L3 = Convert.ToInt32(label3.Text);
            label3.BackColor = Color.Aqua;
            await Task.Delay(1000);
            label3.BackColor = Color.Transparent;
            int L4 = Convert.ToInt32(label4.Text);
            label4.BackColor = Color.Aqua;
            await Task.Delay(1000);
            label4.BackColor = Color.Transparent;
            int L5 = Convert.ToInt32(label5.Text);
            label5.BackColor = Color.Aqua;
            await Task.Delay(1000);
            label5.BackColor = Color.Transparent;
            int L6 = Convert.ToInt32(label6.Text);
            label6.BackColor = Color.Aqua;
            await Task.Delay(1000);
            label6.BackColor = Color.Transparent;
            int L7 = Convert.ToInt32(label7.Text);
            label7.BackColor = Color.Aqua;
            await Task.Delay(1000);
            label7.BackColor = Color.Transparent;
            int L8 = Convert.ToInt32(label8.Text);
            label8.BackColor = Color.Aqua;
            await Task.Delay(1000);
            label8.BackColor = Color.Transparent;

            // groupBox2.ForeColor = Color.Yellow;
            groupBox2.BackColor = Color.MediumSpringGreen;
            if (L1 <= L2)
            {

                label9.Text = L1.ToString();
                label10.Text = L2.ToString();
            }
            else { label9.Text = L2.ToString(); label10.Text = L1.ToString(); }
            groupBox3.BackColor = Color.MediumSpringGreen;
            if (L3 <= L4)
            { label11.Text = L3.ToString(); label12.Text = L4.ToString(); }
            else { label11.Text = L4.ToString(); label12.Text = L3.ToString(); }
            groupBox4.BackColor = Color.MediumSpringGreen;
            if (L5 <= L6)
            { label13.Text = L5.ToString(); label14.Text = L6.ToString(); }
            else { label13.Text = L6.ToString(); label14.Text = L5.ToString(); }
            groupBox5.BackColor = Color.MediumSpringGreen;
            if (L7 <= L8)
            { label15.Text = L7.ToString(); label16.Text = L8.ToString(); }
            else { label15.Text = L8.ToString(); label16.Text = L7.ToString(); }

            groupBox2.BackColor = Color.Aquamarine;
            groupBox3.BackColor = Color.Aquamarine;
            groupBox4.BackColor = Color.Aquamarine;
            groupBox5.BackColor = Color.Aquamarine;
            int L9 = Convert.ToInt32(label9.Text);
            int L10 = Convert.ToInt32(label10.Text);
            int L11 = Convert.ToInt32(label11.Text);
            int L12 = Convert.ToInt32(label12.Text);
            int L13 = Convert.ToInt32(label13.Text);
            int L14 = Convert.ToInt32(label14.Text);
            int L15 = Convert.ToInt32(label15.Text);
            int L16 = Convert.ToInt32(label16.Text);

            if (L9 <= L11)
            {
                label17.Text = L9.ToString();
                if (L10 <= L11)
                {
                    label18.Text = L10.ToString();
                    label19.Text = L11.ToString();
                    label20.Text = L12.ToString();
                }
                else
                {
                    label18.Text = L11.ToString();
                    if (L10 <= L12)
                    {
                        label19.Text = L10.ToString();
                        label20.Text = L12.ToString();
                    }
                }
            }
            else
            {
                label17.Text = L11.ToString();
                if (L9 <= L12)
                {
                    label18.Text = L9.ToString();
                    if (L10 <= L12)
                    {
                        label19.Text = L10.ToString();
                        label20.Text = L12.ToString();
                    }
                    else
                    {
                        label19.Text = L12.ToString();
                        label20.Text = L10.ToString();
                    }
                }
                else
                {
                    label18.Text = L12.ToString();
                    label19.Text = L9.ToString();
                    label20.Text = L10.ToString();
                }
            }


            if (L13 <= L15)
            {
                label21.Text = L13.ToString();
                if (L14 <= L15)
                {
                    label22.Text = L14.ToString();
                    label23.Text = L15.ToString();
                    label24.Text = L16.ToString();
                }
                else
                {
                    label22.Text = L15.ToString();
                    if (L14 <= L16)
                    {
                        label23.Text = L14.ToString();
                        label24.Text = L16.ToString();
                    }
                }
            }
            else
            {
                label21.Text = L15.ToString();
                if (L13 <= L16)
                {
                    label22.Text = 139.ToString();
                    if (L14 <= L16)
                    {
                        label23.Text = L14.ToString();
                        label24.Text = L16.ToString();
                    }
                    else
                    {
                        label13.Text = L16.ToString();
                        label24.Text = L14.ToString();
                    }
                }
                else
                {
                    label22.Text = L16.ToString();
                    label23.Text = L13.ToString();
                    label24.Text = L14.ToString();
                }
            }
            List<int> arg1 = new List<int>();
            arg1.Add(int.Parse(label17.Text));
            arg1.Add(int.Parse(label18.Text));
            arg1.Add(int.Parse(label19.Text));
            arg1.Add(int.Parse(label20.Text));

            arg1.Add(int.Parse(label21.Text));
            arg1.Add(int.Parse(label22.Text));
            arg1.Add(int.Parse(label23.Text));
            arg1.Add(int.Parse(label24.Text));
            arg1.Sort();

            label25.Text = arg1[0].ToString();
            label26.Text = arg1[1].ToString();
            label27.Text = arg1[2].ToString();
            label28.Text = arg1[3].ToString();

            label29.Text = arg1[4].ToString();
            label30.Text = arg1[5].ToString();
            label31.Text = arg1[6].ToString();
            label32.Text = arg1[7].ToString();


        }



        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.MaxLength = 3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Algiritm2_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Algiritm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

} 