using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;
        //1
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }
        //2
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }
        //3
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }
        //4
        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }
        //5
        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }
        //6
        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        
        }
        //7
        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        
        }
        //8
        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }
        //9
        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        //0
        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        // -
        private void Button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }
        // +
        private void Button12_Click(object sender, EventArgs e)
        {   num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }
        // *
        private void Button13_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }
        // /
        private void Button14_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4; 
        }
        //=
        private void Button16_Click(object sender, EventArgs e)
        {
            compute(count);  
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
        // sqrt
        private void Button17_Click(object sender, EventArgs e)
        {
            double  sqrt=Math.Sqrt(float.Parse(textBox1.Text));
            textBox1.Text = sqrt.ToString();
        }
        // C
        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0; 
        }
        // .
        private void Button18_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag=0;
            string text = textBox1.Text;
            for (int i = 0;i < c; i++)
            { if (text[i].ToString() == ".") { flag = 1; break; } else { flag = 0; } }
            if (flag==0)
            {textBox1.Text= textBox1.Text + ".";}
        }
        // 1/x
        private void Button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1/float.Parse(textBox1.Text)).ToString();
        }
        // <---
        private void Button19_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength-1;
            string text = textBox1.Text;  // MessageBox.Show(lenght.ToString());
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i]; 
        }
        // + -
        int check = 1;
        private void Button21_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                string text = textBox1.Text;
                if (check == 1)
                {
                    textBox1.Text = "-" + textBox1.Text;
                    check = 2;
                }
                else if (check == 2)
                {
                    int lenght = textBox1.TextLength; textBox1.Clear();
                    for (int i = 1; i < lenght; i++) { textBox1.Text = textBox1.Text + text[i]; }
                    check = 1;
                }
            }
        }
        // CE
        private void Button22_Click(object sender, EventArgs e)
        {
            if (num1==0 && textBox1.TextLength>0)
            { num1 = 0; textBox1.Clear();  }
            else if (num1>0 && textBox1.TextLength>0)
            { textBox1.Clear();}
        }
     }
}
