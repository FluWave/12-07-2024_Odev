namespace _5_TekÇiftMethod;

class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        var sayi1 = new Kontrol();

        if (sayi % 2 == 0)
        {
            System.Console.WriteLine("Çift sayı ");
        }
        if (sayi % 2 == 1)
        {
            System.Console.WriteLine("Tek sayı ");
        }


    }
}
class Kontrol
{
    public int Deger { get; set; }
    public int sayi { get; set; }
    public int sayi1 { get; set; }


}


