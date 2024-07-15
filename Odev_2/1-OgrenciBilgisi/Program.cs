using OgrenciInfo;

namespace _1_OgrenciBilgisi;

class OgrenciBilgi 
{
    public static void Main(string[] args)
    {
        Ogrenci student =  new Ogrenci();
        student.OgrenciAd = "Miraç";
        student.OgrenciSoyad = "Yenice";
        
        student.OgrenciYas = "24";
        student.OgrenciNotu = "85";

        System.Console.WriteLine($"{student.OgrenciAd} {student.OgrenciSoyad}");
        System.Console.WriteLine($"{student.OgrenciYas} yaşında");
        System.Console.WriteLine($"{student.OgrenciNotu} puan aldı.");

    }
}
