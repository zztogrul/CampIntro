
int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
{
    Console.WriteLine(sayi1);
}

int[] sayilar1 = new int[] { 10, 20, 30 };
int[] sayilar2 = new int[] { 100, 200, 300 };
sayilar1 = sayilar2;
sayilar2[0] = 999;
{
    Console.WriteLine(sayilar1[0]);
}

// Değerler = Int, decimal, fload, double, bool(0,1)
//Referanslar = Array, class, interface
//Stack - (Yığın) değer tipler
// Heap - (Yığın) referans değerler