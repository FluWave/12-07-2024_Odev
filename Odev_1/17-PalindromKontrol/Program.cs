using System.Linq;
using System.Reflection;


namespace _17_PalindromKontrol;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Kelimeyi yazın: ");
        string text = Console.ReadLine();

        string ters = new string(text.Reverse().ToArray());


        if (text == ters)
        {
            System.Console.WriteLine("Bu Palindrom bir kelime! ");
        }
        else
        {
            Console.WriteLine("Bu kelime palindrom değil! ");
        }


    }
}
