using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " İsimli Müşteri Eklendi");
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            Console.WriteLine("Listelenen müşteriler aşağıdaki gibidir : ");
            foreach (Musteri m in musteriler)
                Console.WriteLine(m.Id + " " + m.Name + " " + m.SurName + " " + m.DateOfBirth);
            Console.WriteLine("-------------------------");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " İsimli Müşteri Silindi");
        }

    }
}
