using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classnesne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, cevre, alan;
            s1= Convert .ToDouble(textBox1.Text);
            s2= Convert .ToDouble(textBox2.Text);
            Dikdörtgen x = new Dikdörtgen();
            alan= s1 * s2;
            cevre= 2*(s1 + s2);
            label3.Text = "Cevre = " + cevre.ToString();
            label4.Text = "Alan = " + alan.ToString();

        }
    }
}
