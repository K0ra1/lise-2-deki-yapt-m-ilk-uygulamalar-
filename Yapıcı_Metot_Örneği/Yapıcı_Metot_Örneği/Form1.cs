using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yapıcı_Metot_Örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DortIslem islem = new DortIslem();
            label3.Text = Convert.ToString(islem.Topla();
            label4.Text=Convert.ToString(islem.Carp());

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DortIslem dortIslem = new DortIslem();
            islem.sayi1 = Convert.ToInt32(textBox1.Text);
            label3.Text = Convert.ToString(dortIslem.Topla);
             abel
        }
    }
}-