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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! 我是李政民");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.Text = "我的名字";
            //textBox1.Text = "李政民";
            button1.Text = "点击一下";
        }
    }
}
