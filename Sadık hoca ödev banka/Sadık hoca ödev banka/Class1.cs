using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sadık_hoca_ödev_banka
{
    internal class Banka 
    {
        public int SiraNo { get; private set; } = 0;
        Random rnd = new Random();

        Queue<int> M1 = new Queue<int>();
        Queue<int> M2 = new Queue<int>();
        Queue<int> M3 = new Queue<int>();
        Queue<int> M4 = new Queue<int>();
        Queue<int> M5 = new Queue<int>();

        public (int sira, string gise) SiraAl()
        {
            SiraNo++;

            int secim = rnd.Next(1, 6);
            string gise = "M" + secim;

            switch (secim)
            {
                case 1: M1.Enqueue(SiraNo); break;
                case 2: M2.Enqueue(SiraNo); break;
                case 3: M3.Enqueue(SiraNo); break;
                case 4: M4.Enqueue(SiraNo); break;
                case 5: M5.Enqueue(SiraNo); break;
            }
            return ( SiraNo, gise);

        }
        public int? Cagir(string gise)
        {
            switch(gise)
            {
               case "M1": return M1.Count > 0 ? M1.Dequeue() : (int?)null;
              case "M2": return M2.Count > 0 ? M2.Dequeue() : (int?)null;
             case "M3": return M3.Count > 0 ? M3.Dequeue() : (int?)null;
               case "M4": return M4.Count > 0 ? M4.Dequeue() : (int?)null;
                case "M5": return M5.Count > 0 ? M5.Dequeue() : (int?)null;
                default : return null;
            }
        }
    }
}
