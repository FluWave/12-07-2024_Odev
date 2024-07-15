namespace _8_TersÇevirmeProgramı;

class Program
{
    static void Main(string[] args)
    {
        int[] sayi = [5];
        Array.Reverse(sayi);

        System.Console.WriteLine("Ters Çevrilen dizi: ");

        foreach (var dizi in sayi)
        {
            System.Console.WriteLine("[i]" + sayi);
        }
        

    }
}
