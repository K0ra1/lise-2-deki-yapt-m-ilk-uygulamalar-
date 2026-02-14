using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadık_hoca_ödev_banka
{
    public partial class Form1 : Form
    {
        int siraNo = 0;
        Random rnd = new Random();

        Queue<int> kuyrukM1 = new Queue<int>();
        Queue<int> kuyrukM2 = new Queue<int>();
        Queue<int> kuyrukM3 = new Queue<int>();
        Queue<int> kuyrukM4 = new Queue<int>();
        Queue<int> kuyrukM5 = new Queue<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            siraNo++;

            int secim = rnd.Next(1, 6); // 1-5 arası
            string gise = "M" + secim;

           

            

           listBox1.Items.Add(siraNo);
            listBox2.Items.Add(siraNo + " → " + gise);

            switch (secim)
            {
                case 1: kuyrukM1.Enqueue(siraNo); break;
                case 2: kuyrukM2.Enqueue(siraNo); break;
                case 3: kuyrukM3.Enqueue(siraNo); break;
                case 4: kuyrukM4.Enqueue(siraNo); break;
                case 5: kuyrukM5.Enqueue(siraNo); break;
            }

            switch (secim)
            {
                case 1: kuyrukM1.Enqueue(siraNo); break;
                case 2: kuyrukM2.Enqueue(siraNo); break;
                case 3: kuyrukM3.Enqueue(siraNo); break;
                case 4: kuyrukM4.Enqueue(siraNo); break;
                case 5: kuyrukM5.Enqueue(siraNo); break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kuyrukM1.Count > 0)
                lblM1.Text = kuyrukM1.Dequeue().ToString();
            else
                MessageBox.Show("M1 kuyruğu boş");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kuyrukM2.Count > 0)
                lblM2.Text = kuyrukM2.Dequeue().ToString();
            else
                MessageBox.Show("M2 kuyruğu boş");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kuyrukM3.Count > 0)
                lblM3.Text = kuyrukM3.Dequeue().ToString();
            else
                MessageBox.Show("M3 kuyruğu boş");
        }

        private void button5_Click(object sender, EventArgs e)
        {
             if (kuyrukM4.Count > 0)
                lblM4.Text = kuyrukM4.Dequeue().ToString();
            else
                MessageBox.Show("M4 kuyruğu boş");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (kuyrukM5.Count > 0)
                lblM5.Text = kuyrukM5.Dequeue().ToString();
            else
                MessageBox.Show("M5 kuyruğu boş");

        }
    }
}
