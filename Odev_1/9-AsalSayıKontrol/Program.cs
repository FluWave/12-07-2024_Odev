namespace _9_AsalSayıKontrol;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        if (IsActive(sayi))
        {
            System.Console.Write(" Asal sayıdır. ");
        }
        else
        {
            System.Console.Write("Asal değildir! ");
        }
    }
    static bool IsActive(int sayi)
    {
        if (sayi <= 1)
        {
            return false;
        }
        for (int i = 2; i < Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
