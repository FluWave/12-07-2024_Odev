namespace _13_SesliHarf_Adedi;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Kelime veya cümle girin: ");
        var sonuc = Console.ReadLine();
        char[] sesliHarfler = ['a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'];
        int sesliHarfAdedi = 0;
        for (int i = 0; i < sonuc.Length; i++)
        {
            if (sesliHarfler.Contains(sonuc[i]))
            {
                sesliHarfAdedi++;
            }
        }
        System.Console.WriteLine("sesli harf saysısı: " + sesliHarfAdedi);

    }
}
