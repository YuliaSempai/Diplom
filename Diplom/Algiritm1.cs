using System;
using System.Threading;
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
    public partial class Algiritm1 : Form
    {
        public Algiritm1()
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
            HELP1 H1 = new HELP1();
            H1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 3;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 3;
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
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 11)
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 12)
                e.Handled = true;
        }

        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 13)
                e.Handled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Histori1 Hi1 = new Histori1();
            Hi1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            label6.Text = null;
            label3.Text = null;
            label1.Text = null;
            label5.Text = null;
            label4.Text = null;
            label2.Text = null;

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

         
           for(int i = 0; i<6; i++)
            {
                labels[i].Text = textBoxs[i].Text;
            }
            labels[0].BackColor = Color.Aqua;
            for (int j = 1; j < labels.Count; j++)
            {
                labels[j].BackColor = Color.Yellow;
                await Task.Delay(500);
                int key = Convert.ToInt32(labels[j].Text);

                int i = j - 1;
                while ((i >= 0) && (Convert.ToInt32(labels[i].Text) > key))
                {
                   // labels[i+1].BackColor = Color.Red;
                    labels[i].ForeColor = Color.Red;
                    labels[i + 1].Text = labels[i].Text;
                    labels[i].Text = key.ToString();
                    
                    await Task.Delay(500);
                    //labels[i + 1].BackColor = Color.Aquamarine;
                    labels[i].ForeColor = Color.Black;
                    i = i - 1;
                }
                labels[j].BackColor = Color.Aqua;
            }
                  
      
        textBoxs = null;
            labels = null;
        }
        private static String CheckIfNull(String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                str = "0";
            }
              
            return str;
        }
        public static void sortTextBoxValue(Control parent)
        {
            List<TextBox> textBoxs = new List<TextBox>();
            List<Label> labels = new List<Label>();
            //textBoxs.Add(textBox1);

            //fillLabeles(labels, textBoxs);
            //labels = sortTextBox(labels);
            textBoxs = null;
            labels = null;
            //foreach (Control c in parent.Controls)
            //{
            //    if (c.GetType() == typeof(TextBox))
            //    {
            //        c.Text = CheckIfNull(c.Text);
            //        textBoxs.Add((TextBox)c);
            //        MessageBox.Show(textBoxs[Int32.Parse(textBoxs.Count.ToString()) - 1].ToString());
            //    }
            //    if (c.GetType() == typeof(Label))
            //    {
            //        labels.Add((Label)c);
            //    }
            //    if (c.GetType() == typeof(GroupBox))
            //        sortTextBoxValue(c);
            //}

            //textBoxs = sortTextBox(textBoxs);

        }
        private static void fillLabeles(List<Label> labels, List<TextBox> textBoxs)
        {
        //    if (textBoxs.Count > labels.Count)
        //    {
        //        labels.Add(new Label());
        //    }
        //    else
        //    {
        //        textBoxs.Add(new TextBox());
        //    }
        //    for (int i = 0; i < labels.Count; i++)
        //    {
          MessageBox.Show("hey"+textBoxs.Count+" "+labels.Count);
        //        //  await Task.Delay(1000);
        //       // labels[i].BackColor = Color.Yellow;
        //        labels[i].Text = textBoxs[i].Text;
        //   }
        }

        private static List<Label> sortTextBox(List<Label> textBoxs)
        {
            if (textBoxs.Count > 0&&textBoxs!=null)
            {
                //MessageBox.Show(textBoxs.Count.ToString());
                int[] intArr = new int[6];
                for (int i = 0; i < textBoxs.Count; i++)
                {
                    int n = Convert.ToInt32(textBoxs[i].Text);
                    MessageBox.Show(n.ToString());
                    intArr[i] = Convert.ToInt32(textBoxs[i].Text);
                }
                for (int j = 1; j < intArr.Length; j++)
                {
                    int key = intArr[j];
                    int i = j - 1;
                    while ((i > 0) && (intArr[i] > key))
                    {
                        intArr[i + 1] = intArr[i];
                        i = i - 1;
                        intArr[i + 1] = key;
                    }
                }
                for (int i = 0; i < textBoxs.Count; i++)
                {
                    textBoxs[i].Text = intArr[i].ToString();
                }
            }
           
    //            for j = 2 to A.length
    //key = A[j]
    //i = j - 1
    //while i > 0 and A[i] > key
    //     A[i + 1] = A[i]
    //     i = i - 1
    //A[i + 1] = key
                       //    int j = i;
                       //    while (j > 0 && cur < Convert.ToInt32(textBoxs[j - 1].Text))
                       //    {
                       //        textBoxs[j].Text = textBoxs[j - 1].Text;
                       //        j--;
                       //    }

            //    textBoxs[j].Text = cur.ToString();
            //}
            return textBoxs;
        }


        private static void fillStrings(List<string> stringlist, List<TextBox> textBoxs)
        {
            for (int i = 0; i < textBoxs.Count; i++)
            {
                stringlist[i] = textBoxs[i].Text;
            }

        }

       

        private static List<string> sortStrings(List<string> Stringlist)
        {
            for (int i = 1; i < Stringlist.Count; i++)
            {
                int cur = Convert.ToInt32(Stringlist[i]);
                int j = i;
                while (j > 0 && cur < Convert.ToInt32(Stringlist[j - 1]))
                {
                    Stringlist[j] = Stringlist[j - 1];
                    j--;
                }
                
                Stringlist[j] = cur.ToString();
            }

        
            return Stringlist;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 3;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 3;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 3;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 3;
        }

        private void Algiritm1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Algiritm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
