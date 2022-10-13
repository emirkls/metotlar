using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("{0} Müsteri Eklendi",musteri.Adi);          
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} musteri silindi",musteri.Adi);
        }
    }
}
