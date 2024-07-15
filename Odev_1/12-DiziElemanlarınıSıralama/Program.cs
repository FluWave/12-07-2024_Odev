namespace _12_DiziElemanlarınıSıralama;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = { 1, 2, 3, 34, 44, -5, -4, -6, 22, 23, 57, 78, -98, -85, 10, -44 };
        Array.Sort(dizi);
        System.Console.WriteLine("Sıralanmış dizi: ");
        foreach (int sayi in dizi)
        {
            Console.Write(" ( " + sayi + " ) ");
        }
    }
}
