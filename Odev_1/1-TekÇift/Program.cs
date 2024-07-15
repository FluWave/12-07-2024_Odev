namespace TekÇift;

class Program
{
    static void Main(string[] args)
    {

        System.Console.Write("Bir sayı Giriniz: ");

        int sayi1 = int.Parse(Console.ReadLine());



        if (sayi1 % 2 == 0)
        {
            System.Console.WriteLine($"Girdiğiniz {sayi1} sayısı çift sayıdır");
        }
        if (sayi1 % 2 == 1)
        {
            System.Console.WriteLine($"Girdiğiniz {sayi1} sayısı tek sayıdır.");
        }

    }
}
