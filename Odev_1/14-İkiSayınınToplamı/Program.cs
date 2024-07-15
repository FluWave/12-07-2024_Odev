namespace _14_İkiSayınınToplamı;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Birinci sayıyı girin: ");
        int sayi1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("İkinci sayıyı girin: ");
        int sayi2 = int.Parse(Console.ReadLine());
        int toplam = sayi1 + sayi2;
        System.Console.WriteLine("Sayıların toplamı: " + toplam);
    }
}
