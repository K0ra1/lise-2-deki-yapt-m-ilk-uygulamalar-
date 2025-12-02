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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kalıtım
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double s1, s2, f, s3;

        private void button3_Click(object sender, EventArgs e)
        {
            s3 = Convert.ToDouble(textBox3.Text);
            label5.Text = islem.cikar(f, s3).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s3 = Convert.ToDouble(textBox3.Text);
            label5.Text = islem.carp(f, s3).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s3 = Convert.ToDouble(textBox3.Text);
            label5.Text = islem.bol(f, s3).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s3 = Convert.ToDouble(textBox3.Text);
            label5.Text = islem.topla(f, s3).ToString();
        }

        hesapla islem = new hesapla();
        private void button1_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            f = islem.fonksiyon(s1, s2);
            label4.Text = islem.fonksiyon(s1, s2).ToString();
        }
    }
}
