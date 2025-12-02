using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buyuk_Olanı_Bul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1,sayi2;
            Buyuk_olanı_bul BuyukBul= new Buyuk_olanı_bul();
            sayi1 = Convert .ToInt32(textBox1.Text);    
            sayi2 = Convert .ToInt32(textBox2.Text);
            textBox3.Text=BuyukBul.Bul(sayi1 ,sayi2).ToString();  



        }
    }
}
