namespace _11_DizidekiEnKüçükSayi;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = { -12, 46, 38, 89, 92, -11, 23, 25, 77, 0, -34 };

        int enk = dizi[0];

        for (int i = 1; i < dizi.Length; i++)
        {
            if (dizi[i] < enk)
            {
                enk = dizi[i];
            }
        }
        System.Console.WriteLine("En Küçük sayı: " + enk);
    }
}
