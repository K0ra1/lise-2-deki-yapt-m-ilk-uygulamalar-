using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yapıcı_Metot_Örneği
{
    internal class DortIslem
    {
        public int sayi1;
        public int sayi2;

        public DortIslem()
        {
            {
                this.sayi1 = sayi1;
                this.sayi2 = sayi2;
            }

        }
        public DortIslem(int sayi1)
        {
            this.sayi1 = sayi1;
            this.sayi2 = 3;

        }
        public DortIslem(int sayi1, int sayi2) 
        {
            this.sayi1 = sayi1;
            this.sayi2 = sayi2;
            
        }
        public int Topla ()
        {
            return this.sayi1 + this.sayi2;

        }
        public int Carp()
        {
            return this.sayi1 - this.sayi2;
        }
    }
}





