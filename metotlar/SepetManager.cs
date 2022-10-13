using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("{0} sepete eklendi...",urun.Adi);

        }

        public void Ekle2(string urunAdi,string urunAciklamasi,double urunFiyati)
        {
            Console.WriteLine("sepete eklendi : " + urunAdi);
        }

    }
}
