namespace _10_DizidekiEnBüyükSayı;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = {12,46,38,89,92,1,23,25,77};
        
        int enb = dizi[0];
        
        for (int i = 1; i < dizi.Length; i++)
        {
            if (dizi[i]> enb)
            {
                enb = dizi[i];
            }
        }
         System.Console.WriteLine("En büyük sayı: " + enb);   

    }
}
