namespace _20_SayılarınKareleri;

class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            double kare = Karesi(i);
            Console.WriteLine("{0} sayısının karesi: {1}", i, kare);
        }
    }

    public static double Karesi(double sayi1)
    {
        return sayi1 * sayi1;
    }
}


