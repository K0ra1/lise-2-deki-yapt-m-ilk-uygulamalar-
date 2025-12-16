using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Level1")
            {
                listBox1.Items.Add(0);
            }
            else if (textBox1.Text == "level2")
            {
                listBox1.Items.Add(1);
            }
            else if (textBox1.Text == "level3")
            {
                listBox1.Items.Add(2);
            }
            else if (textBox1.Text =="level4")
            {
                listBox1.Items.Add(3);
            }
            else if (textBox1.Text =="level5")
            {
                listBox1.Items.Add(4);
            }
            else if (textBox1.Text =="level6")
            {
                listBox1.Items.Add(5);
            }
            else
            {
                MessageBox.Show("Hatalı Giriş  ");
            }

        }
    }
}
