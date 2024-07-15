namespace _7_ToplamaIşlemi;

class Program
{
    static void Main(string[] args)
    {
        int[] sayi = new int[10];
        int toplam = 0;
        System.Console.Write("1.Sayıyı Giriniz:");
        sayi[0] = int.Parse(Console.ReadLine());
        System.Console.Write("2.Sayıyı Giriniz:");
        sayi[1] = int.Parse(Console.ReadLine());
        System.Console.Write("3.Sayıyı Giriniz:");
        sayi[2] = int.Parse(Console.ReadLine());
        System.Console.Write("4.Sayıyı Giriniz:");
        sayi[3] = int.Parse(Console.ReadLine());
        System.Console.Write("5.Sayıyı Giriniz:");
        sayi[4] = int.Parse(Console.ReadLine());
        System.Console.Write("6.Sayıyı Giriniz:");
        sayi[5] = int.Parse(Console.ReadLine());
        System.Console.Write("7.Sayıyı Giriniz:");
        sayi[6] = int.Parse(Console.ReadLine());
        System.Console.Write("8.Sayıyı Giriniz:");
        sayi[7] = int.Parse(Console.ReadLine());
        System.Console.Write("9.Sayıyı Giriniz:");
        sayi[8] = int.Parse(Console.ReadLine());
        System.Console.Write("10.Sayıyı Giriniz:");
        sayi[9] = int.Parse(Console.ReadLine());
        for (int i = 0; i < 10; i++)
        {
            toplam += sayi[i];
        }

        Console.Write($"Girdiğiniz sayıların Toplamı: " + toplam);


        #region ToplamaIkinciYol
        // {
        //     int[] sayi1 = new int[10];
        //     int toplama = 0;

        //     for (int i = 0; i < 10; i++)
        //     {
        //         System.Console.WriteLine($"{0}. sayıyı giriniz.");
        //         sayi1[i] = int.Parse(Console.ReadLine());
        //     }
        //     for (int i = 0; i < 10; i++)
        //     {
        //         toplama += sayi1[i];
        //     }
        //     System.Console.WriteLine($"Sayıların Toplamı "+ toplama);
        // }
            
        #endregion









    }
}
