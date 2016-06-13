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
            G.ShowDialog();
        }

        private void Algiritm4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            /* if (String.IsNullOrEmpty(textBox1.Text))
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
             int L1 = Convert.ToInt32(label1.Text);
             int L2 = Convert.ToInt32(label2.Text);
             int L3 = Convert.ToInt32(label3.Text);
             int L4 = Convert.ToInt32(label4.Text);
             int L5 = Convert.ToInt32(label5.Text);
             int L6 = Convert.ToInt32(label6.Text);

             await Task.Delay(500);
             if (L1 < L2)
             {
                 label1.BackColor = Color.Yellow;
                 await Task.Delay(500);
                 await Task.Delay(500); label1.Text = L1.ToString();
                 label2.BackColor = Color.Yellow;
                 await Task.Delay(500);
                 await Task.Delay(500); label2.Text = L2.ToString();
             }
             else
             {
                 label1.BackColor = Color.Yellow;
                 await Task.Delay(500);
                 await Task.Delay(500); label1.Text = L2.ToString();
                 label2.BackColor = Color.Yellow;
                 await Task.Delay(500);
                 await Task.Delay(500); label2.Text = L1.ToString();
             }


             await Task.Delay(500);
             if (L2 < L3)
             {
                 label2.BackColor = Color.Yellow;
                 await Task.Delay(500);
                 await Task.Delay(500); label2.Text = L2.ToString();
                 label3.BackColor = Color.Yellow;
                 await Task.Delay(500);
                 await Task.Delay(500); label3.Text = L3.ToString();
             }
             else
             {
                 label2.BackColor = Color.Yellow;
                 await Task.Delay(500);
                 await Task.Delay(500); label2.Text = L3.ToString();
                 label3.BackColor = Color.Yellow;
                 await Task.Delay(500);
                 await Task.Delay(500); label3.Text = L2.ToString();
             }

             if (L3 < L4)
             {
                 await Task.Delay(500);
                 label3.BackColor = Color.Yellow;
                 await Task.Delay(500); label3.Text = L3.ToString();
                 label4.BackColor = Color.Yellow;
                 await Task.Delay(500);
                 await Task.Delay(500); label4.Text = L4.ToString();
             }
             else
             {
                 await Task.Delay(500);
                 label3.BackColor = Color.Yellow;
                 await Task.Delay(500); label3.Text = L4.ToString();
                 await Task.Delay(500);
                 label4.BackColor = Color.Yellow;
                 await Task.Delay(500); label4.Text = L3.ToString();
             }

             if (L4 < L5)
             {
                 await Task.Delay(500);
                 label4.BackColor = Color.Yellow;
                 await Task.Delay(500); label4.Text = L4.ToString();
                 label5.BackColor = Color.Yellow;
                 await Task.Delay(500);
                 await Task.Delay(500); label5.Text = L5.ToString();
             }
             else
             {
                 await Task.Delay(500);
                 label4.BackColor = Color.Yellow;
                 await Task.Delay(500); label4.Text = L5.ToString();
                 await Task.Delay(500);
                 label5.BackColor = Color.Yellow;
                 await Task.Delay(500); label5.Text = L4.ToString();
             }


             if (L5 < L6)
             {
                 await Task.Delay(500);
                 label5.BackColor = Color.Yellow;
                 await Task.Delay(500); label5.Text = L5.ToString();
                 label6.BackColor = Color.Yellow;
                 await Task.Delay(500);
                 await Task.Delay(500); label6.Text = L6.ToString();
             }
             else
             {
                 await Task.Delay(500);
                 label5.BackColor = Color.Yellow;
                 await Task.Delay(500); label5.Text = L6.ToString();
                 await Task.Delay(500);
                 label6.BackColor = Color.Yellow;
                 await Task.Delay(500); label6.Text = L5.ToString();
             }

            */
            int[] arrTaxtBox = new int[6];
            arrTaxtBox[0] = int.Parse(textBox1.Text);
            arrTaxtBox[1] = int.Parse(textBox2.Text);

            arrTaxtBox[2] = int.Parse(textBox3.Text);
            arrTaxtBox[3] = int.Parse(textBox4.Text);

            arrTaxtBox[4] = int.Parse(textBox5.Text);
            arrTaxtBox[5] = int.Parse(textBox6.Text);

            label1.Text = arrTaxtBox[0].ToString();
            label2.Text = arrTaxtBox[1].ToString();
            label3.Text = arrTaxtBox[2].ToString();

            label4.Text = arrTaxtBox[3].ToString();
            label5.Text = arrTaxtBox[4].ToString();
            label6.Text = arrTaxtBox[5].ToString();

            //for (int i = 0; i < 6; i++)
            //{
            //    int val = arrTaxtBox[i];
            //    for (int j = 1+i; j < 6; j++)
            //    {
            //        int val2 = arrTaxtBox[j];
            //        if (val > val2)
            //        {
            //            arrTaxtBox[i] = val2;
            //            arrTaxtBox[j] = val;
            //            break;
            //        }

            //    }
            //    label1.Text = arrTaxtBox[0].ToString();
            //    label2.Text = arrTaxtBox[1].ToString();
            //    label3.Text = arrTaxtBox[2].ToString();

            //    label4.Text = arrTaxtBox[3].ToString();
            //    label5.Text = arrTaxtBox[4].ToString();
            //    label6.Text = arrTaxtBox[5].ToString();
            //}
            int n, buf, count;
            count = 0;
            n = 6;
         
            for (int k = n - 1; k > 0; k--)
            {
                count++;
                label7.Text = "Крок " + count + "!";
                for (int i = 0; i < k; i++)
                {

                    if (arrTaxtBox[i] > arrTaxtBox[i + 1])
                    {
                        buf = arrTaxtBox[i];
                        arrTaxtBox[i] = arrTaxtBox[i + 1];
                        arrTaxtBox[i + 1] = buf;

                    }
                    label1.Text = arrTaxtBox[0].ToString();
                    label2.Text = arrTaxtBox[1].ToString();
                    label3.Text = arrTaxtBox[2].ToString();

                    label4.Text = arrTaxtBox[3].ToString();
                    label5.Text = arrTaxtBox[4].ToString();
                    label6.Text = arrTaxtBox[5].ToString();
                    await Task.Delay(1000);
                }
            }
                
                    
            //for (int i = 0; i < n; i++)
            //{
            //    label1.Text = arrTaxtBox[0].ToString();
            //    label2.Text = arrTaxtBox[1].ToString();
            //    label3.Text = arrTaxtBox[2].ToString();

            //    label4.Text = arrTaxtBox[3].ToString();
            //    label5.Text = arrTaxtBox[4].ToString();
            //    label6.Text = arrTaxtBox[5].ToString();
            //}



        }
    }
}
