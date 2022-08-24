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
            Console.WriteLine("Müşteri Eklendi" + " " + musteri.Id);
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi" + " " + musteri.Id);
        }
      public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi" + " " + musteri.Id);
        }
    }
}
