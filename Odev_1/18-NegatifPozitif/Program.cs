namespace _18_NegatifPozitif;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı Girin: ");
        int sayi = int.Parse(Console.ReadLine());
        if (sayi < 0)
        {
            System.Console.WriteLine("Girdiğiniz sayı Negatif! ");
        }
        if (sayi > 0)
        {
            System.Console.WriteLine("Girdiğiniz sayı Pozitif! ");
        }
        else if (sayi == 0)
        {
            System.Console.WriteLine("Girdiğiniz sayı Nötr! ");
        }
    }
}
