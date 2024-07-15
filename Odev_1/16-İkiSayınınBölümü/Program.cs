namespace _16_İkiSayınınBölümü;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bölünen sayıyı girin: ");
        int bolunen = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Bölen sayıyı Girin: ");
        int bolen = int.Parse(Console.ReadLine());
        float sonuc = bolunen / bolen;
        if (bolen == 0)
        {
            Console.WriteLine("Bölünen sayı sıfır(0) olamaz!");
        }
        if (bolen != 0)
        {
            System.Console.WriteLine("sonuc" + sonuc);
        }
    }
}
