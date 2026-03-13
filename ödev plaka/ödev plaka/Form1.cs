using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_plaka
{
    public partial class Form1 : Form
    {
        List<Şehir> tumSehirler = new List<Şehir>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] iller = { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", 
                "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum"
                , "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri",
                "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", 
                "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", 
                "Aksaray", "Bayburt", "Karaman", "Kırıkkale","Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };

            for (int i = 0; i < iller.Length; i++)
            {
                tumSehirler.Add(new Şehir { PlakaNo = i + 1, SehirAdi = iller[i] });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int .TryParse(textBox1.Text, out int girilenPlaka))
            {
                Şehir bulunan = tumSehirler.FirstOrDefault(s=> s.PlakaNo == girilenPlaka);
                if (bulunan != null)
                {
                    listBox1.Items.Add(bulunan.ToString());
                }
                else
                {
                    MessageBox.Show("1,81 arası Bir Palaka Giriniz ");
                }

            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Plaka Numarası Giriniz ");
            }
        }
    }
    
}
