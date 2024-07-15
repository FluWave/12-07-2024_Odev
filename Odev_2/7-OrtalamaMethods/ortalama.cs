using System;

namespace DiziOrtalama
{
    public class DiziHesap
    {

        public double CalculateAverage(int[] sayilar)
        {
            if (sayilar == null || sayilar.Length == 0)
            {
                new ArgumentException("Dizi boş olamaz.");
            }

            double sum = 0;
            foreach (int number in sayilar)
            {
                sum += number;
            }

            return sum / sayilar.Length;
        }
    }

    class Program
    {
        private static int[] sayilar;

        static void Main(string[] args)
        {
            DiziHesap arrayUtils = new DiziHesap();

            int[] numbers = { 1, 2, 3, 4, 5 };

            try
            {
                double average = DiziHesap.CalculateAverage(sayilar);
                Console.WriteLine("Dizinin ortalaması: " + average);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Hata: " + e.Message);
            }
        }
    }
}

