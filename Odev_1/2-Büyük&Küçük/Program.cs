namespace _2_Büyük_Küçük;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1.sayıyı Giriniz: ");
        int sayi1 = int.Parse(Console.ReadLine());
        System.Console.Write("2.sayıyı Giriniz: ");
        int sayi2 = int.Parse(Console.ReadLine());
        if (sayi1 > sayi2)
        {
            System.Console.WriteLine($"Büyük olan sayı: {sayi1}");
        }
        else if (sayi1 < sayi2)
        {
            System.Console.WriteLine($"Büyük olan sayı: {sayi2}");
        }
        else
        {
            System.Console.WriteLine($"İki sayı birbirine eşittir. {sayi1} = {sayi2}");
        }
    }
}
