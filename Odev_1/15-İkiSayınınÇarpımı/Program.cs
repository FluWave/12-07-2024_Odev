namespace _15_İkiSayınınÇarpımı;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı Girin: ");
        int sayi1 = int.Parse(Console.ReadLine());
        System.Console.Write("İkinci sayıyı Girin: ");
        int sayi2 = int.Parse(Console.ReadLine());
        int sonuc = sayi1 * sayi2;
        System.Console.WriteLine("Sayıların çarpımı: " + sonuc);
    }
}
