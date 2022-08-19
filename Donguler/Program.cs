// See https://aka.ms/new-console-template for more information

string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Porgramlamaya Başlangıç İçin Temel Kurs";
string kurs3 = "Java";

// array - dizi

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
    "Porgramlamaya Başlangıç İçin Temel Kurs",
    "Java", "Python" };


for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("For Bitti");
// Foreach diziyi tek tek gezer
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine("sayfa Sonu = footer");