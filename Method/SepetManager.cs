﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class SepetManager
    {
       public void Ekle(Product urun)

        {
            Console.WriteLine("Tebrikler. Sepete Eklendi :" + urun.Adi );
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi :" + urunAdi );
        }
    }
}
