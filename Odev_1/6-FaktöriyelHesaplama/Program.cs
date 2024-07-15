namespace _6_FaktöriyelHesaplama;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı Giriniz:");
        int sayi = int.Parse(Console.ReadLine());
        long faktoriyel = 1;
        for (int i = 1; i <= sayi; i++)
        {
            faktoriyel *= i;
        }
        System.Console.WriteLine($"Sayının Faktöriyeli: {faktoriyel}");
        if (sayi == 0)
        {
            sayi = 1;
        }
    }
}
