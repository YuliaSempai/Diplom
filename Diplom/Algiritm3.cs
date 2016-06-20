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
    public partial class Algiritm3 : Form
    {
        public Algiritm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Glavnay G = new Glavnay();
            G.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HELP3 H3 = new HELP3();
            H3.ShowDialog();
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

        private void button10_Click(object sender, EventArgs e)
        {
            Histori3 Hi3 = new Histori3();
            Hi3.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 7)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 9)
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 10)
                e.Handled = true;
        }


        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 11)
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 13)
                e.Handled = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            List<TextBox> textBoxs = new List<TextBox>();
            List<Label> labels = new List<Label>();

            textBoxs.Add(textBox1);
            textBoxs.Add(textBox2);
            textBoxs.Add(textBox3);
            textBoxs.Add(textBox4);
            textBoxs.Add(textBox5);
            textBoxs.Add(textBox6);

            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);

            List<int> intList = new List<int>();
            for(int u = 0; u < textBoxs.Count; u++)
            {
                intList.Add(Convert.ToInt32(textBoxs[u].Text));
                labels[u].Text=textBoxs[u].Text;
                labels[u].BackColor = Color.Yellow;
                await Task.Delay(500);
                labels[u].BackColor = Color.Aquamarine;
            }
            for(int i=0; i<labels.Count; i++)
            {
                
                int min = intList[0];
                for (int j=0; j < intList.Count; j++)
                {
                   
                 if (min>intList[j])
                    {
                        //labels[i].Text = intList[j].ToString();
                        //intList.Remove(intList[j]);

                        min = intList[j];
                       
                    }
                    
                }
                labels[i].BackColor = Color.Red;
                await Task.Delay(500);
                labels[i].Text = min.ToString();
                labels[i].ForeColor = Color.White;
                intList.Remove(min);
                labels[i].BackColor = Color.Aquamarine;

            }
            for(int i = 0; i<labels.Count; i++)
            {
                labels[i].ForeColor = Color.Black;
            }
            ////    public static List<int> Selection(List<int> list)
            ////{
            ////List<TextBox> textBoxs = new List<TextBox>();
            ////List<Label> labels = new List<Label>();
            ////textBoxs = sortTextBox(textBoxs);
            ////fillLabeles(labels, textBoxs);
            ////    for (int i = 0; i < list.Count - 1; i++)
            ////    {
            ////        int min = i;
            ////        for (int j = i + 1; j < list.Count; j++)
            ////        {
            ////            if (list[j] < list[min])
            ////            {

            ////                min = j;

            //    Вывод чисед

            ////            }
            ////        }
            ////        int dummy = list[i];
            ////        list[i] = list[min];
            ////        list[min] = dummy;
            ////    }
            ////    return list; }
        }
         

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 3;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 3;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
                private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
                private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 3;
        }
                private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 3;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 3;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 3;
        }

        private void Algiritm3_Load(object sender, EventArgs e)
        {
            //{
            //    sortTextBoxValue(this);
            //}
        }
        private static String CheckIfNull(String str)
        {
            if (String.IsNullOrEmpty(str))
                str = "0";
            return str;

        }
        private static void takeListsValue(Control parent)
        {
            List<TextBox> textBoxs = new List<TextBox>();
            List<Label> labels = new List<Label>();
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = CheckIfNull(c.Text);
                    textBoxs.Add((TextBox)c);
                }
                if (c.GetType() == typeof(Label))
                {
                    labels.Add((Label)c);
                }
                if (c.GetType() == typeof(GroupBox))
                    takeListsValue(c);
            }

           // textBoxs = sortTextBox(textBoxs);
           // fillLabeles(labels, textBoxs);
          //  textBoxs = null;
          //  labels = null;
        }
        private static void fillLabeles(List<Label> labels, List<TextBox> textBoxs)
        {
            for (int i = 0; i < labels.Count; i++)
            {
                labels[i].Text = textBoxs[i].Text;
            }

        }

        private void Algiritm3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }

