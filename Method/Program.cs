
using Method;

string urunAdi = "Elma";
double fiyati = 15;
string aciklama = "Amaya Elması";

string[] meyveler = new string[] { };

Product urun1 = new Product();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Product urun2 = new Product();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";

Product[] urunler = new Product[] { urun1, urun2 };

foreach(Product urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("................");

}
Console.WriteLine("..........Metotlar........");

// instance - Örnek
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 12);
sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);


