using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_plaka
{
    internal class Şehir
    {
        public int PlakaNo { get; set; }
        public string SehirAdi { get; set; }

        public override string ToString()
        {
            return $"{PlakaNo:D2} - {SehirAdi}";
        }

    }
}
