using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //bool flag = false;
        //int[] A = new int[100];
        //int[] B = new int[100];
        //int[] a = new int[100];
        public int ans;
        char C;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { 
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = "1+1=?";
            timer1.Interval = 1000;//每隔1秒钟触发一次timer1
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            if(flag)
            {
                textBox1.Text = "2+2=?";
                flag = false;
            }
            else
            {
                textBox1.Text = "1+1=?";
                flag = true;
            }
            */
            //for (i = 0; i < 30; i++)
            //{
                Random ran = new Random();
                int k = ran.Next(0, 3);//随机产生算术运算符
                switch (k)
                {
                    case 0:
                        C = '+';
                        break;
                    case 1:
                        C = '-';
                        break;
                    case 2:
                        C = '*';
                        break;
                    case 3:
                        C = '/';
                        break;
                    default:
                        break;
                }
                int a = ran.Next(1, 20);//随机产生第一个1-20的运算数a
                //A[i] = r1;
                int b = ran.Next(1, 20);//随机产生第二个1-20的运算数b
                //B[i] = r2;
                if (C == '+')
                {
                    textBox1.Text = (a + "+" + b + "=?");
                    ans = a + b;//用ans来存储正确答案
                }
                if (C == '-')
                {
                    textBox1.Text = (a + "-" + b + "=?");
                    ans = a - b;
                }
                if (C == '*')
                {
                    textBox1.Text = (a + "*" + b + "=?");
                    ans = a * b;
                }
                if (C == '/')
                {
                    textBox1.Text = (a + "/" + b + "=?");
                    ans = a / b;
                }
            //}
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string answer = textBox2.Text;
            //string an = "2";
            /*
            if (an.Equals(answer))
            {
                textBox2.BackColor = Color.Red;
                textBox3.Text = "100";
            }
            else
            {
                textBox2.BackColor = Color.White;
                textBox3.Text = "0";
            }
            */

            int box2 = int.Parse(textBox2.Text);
            if (box2 == ans)
            {
                textBox2.BackColor = Color.Blue;
                textBox3.Text = "100分";
            }
            else
            {
                textBox2.BackColor = Color.Red;
                textBox3.Text = "0分";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
