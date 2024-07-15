namespace _19_OrtalamaHesaplama;

class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("Dizi sayısı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        int[] sayilar = new int[sayi];

        for (int i = 0; i < sayi; i++)
        {
            System.Console.WriteLine("Dizinin {0}. elemanını girin: ", + i);
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        for (int i = 0; i < sayi; i++)
        {
            toplam += sayilar[i];
        }
        float ortalama = (float)toplam / sayi;

        System.Console.WriteLine("Dizinin ortalaması: " + ortalama);


    }
}
