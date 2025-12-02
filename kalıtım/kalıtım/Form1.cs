using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2;
            Hesapla islem = new Hesapla();
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                textBox3.Text = islem.topla(s1, s2).ToString();
                label4.Text = "+";
            }
            else if (radioButton2.Checked == true)
            {
                textBox3.Text = islem.cikar(s1, s2).ToString();
                label4.Text = "-";
            }
            else if (radioButton3.Checked == true)
            {
                textBox3.Text = islem.carp(s1, s2).ToString();
                label4.Text = "*";
            }
            else if (radioButton4.Checked == true)
            {
                textBox3.Text = islem.bol(s1, s2).ToString();
                label4.Text = "/";
            }
            else if (radioButton5.Checked == true)
            {
                textBox3.Text = islem.mod(s1, s2).ToString();
                label4.Text = "MOD";
            }

        }
    }
}
