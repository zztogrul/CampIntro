
 using ClassMetotDemo;



        

        Musteri musteri1 = new Musteri();
        musteri1.Id = 1;
        musteri1.Adi = "Ahmet";
        musteri1.Soyadi = "Alan";

        Musteri musteri2 = new Musteri();
        musteri2.Id = 2;
        musteri2.Adi = " Hasan";
        musteri2.Soyadi = "Akan";

        Musteri musteri3 = new Musteri();
        musteri3.Id = 3;
        musteri3.Adi = " Salih";
        musteri3.Soyadi = "Yakan";

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Listeleme(musteri2);
        musteriManager.Silme(musteri3);    
