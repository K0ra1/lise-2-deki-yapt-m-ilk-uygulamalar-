using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Sadık_hoca_ödev_banka
{
    public partial class Form1 : Form
    {
        Banka banka = new Banka();
        int siraNo = 0;
        Random rnd = new Random();
        Queue<int> anaKuyruk = new Queue<int>(); 

        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
           var sonuc = banka.SiraAl();

           
            listBox1.Items.Add(sonuc.sira);
        }

        
        private void GiseCagir(string giseAdi)
        {
            if (anaKuyruk.Count > 0)
            {
                int numara = anaKuyruk.Dequeue(); // Sıradaki numarayı çek

                // İSTEDİĞİN 2: M tuşuna basınca TextBox ve ListBox2'ye rastgele (o anki gişe) yazsın
                textBox1.Text = numara + " numara " + giseAdi + " gişesinden çağrıldı.";
                listBox2.Items.Add(numara + " → " + giseAdi);

                // Ekran temiz kalsın diye bekleyenlerden silelim
                listBox1.Items.Remove(numara);
            }
            else
            {
                textBox1.Text = "Bekleyen müşteri yok!";
            }
        }

        // M BUTONLARI (Hepsi hazır, hata verme şansı yok)
        private void button2_Click(object sender, EventArgs e)
        {
            int? numara = banka.Cagir("M1");
            if (numara != null)
            {
                textBox1.Text = numara.ToString(); // M-3'ün yanındaki TextBox
                listBox2.Items.Add(numara + " → M3");
                listBox1.Items.Remove(numara.Value);
            }
        }
        private void button3_Click(object sender, EventArgs e) 
        {
            int? numara = banka.Cagir("M2");
            if (numara != null)
            {
                textBox2.Text = numara.ToString(); 
                listBox2.Items.Add(numara + " → M2");
                listBox1.Items.Remove(numara.Value);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int? numara = banka.Cagir("M3");
            if (numara != null)
            {
                textBox3.Text = numara.ToString(); // M-3'ün yanındaki TextBox
                listBox2.Items.Add(numara + " → M3");
                listBox1.Items.Remove(numara.Value);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int? numara = banka.Cagir("M4");
            if (numara != null)
            {
                textBox4.Text = numara.ToString(); // M-4''ün yanındaki TextBox
                listBox2.Items.Add(numara + " → M4");
                listBox1.Items.Remove(numara.Value);
            }
        }
        
        private void button6_Click(object sender, EventArgs e) 
        {
            int? numara = banka.Cagir("M5");
            if (numara != null)
            {
                textBox5.Text = numara.ToString(); // M-5'in yanındaki TextBox
                listBox2.Items.Add(numara + " → M5");
                listBox1.Items.Remove(numara.Value);
            }
        }
    }
}