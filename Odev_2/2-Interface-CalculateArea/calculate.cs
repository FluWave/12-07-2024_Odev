using.System;
namespace _2_Interface_CalculateArea;

public class CalculateArea
{

    interface Alan
    {
        double CalculateArea();
    }
    class Rectangle
    {
        public double uzunluk { get; set; }
        public double genislik { get; set; }

        public Rectangle(double uzunluk, double genislik)
        {
            uzunluk = uzunluk;
            genislik = genislik;
        }
        public double RectangleArea()
        {
            return uzunluk * genislik;
        }

        class Ucgen : Alan
        {
            public double AnaUzunluk { get; set; }
            public double Height { get; set; }

            public double CalculateArea()
            {
                AnaUzunluk = AnaUzunluk;
                Height = Height;
            }

        }
    }
}