using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınız: ");
            string ad = Console.ReadLine();
            Console.Write("Soyadınız: ");
            string soyad= Console.ReadLine();
            Console.WriteLine();

            Console.Write("Doğum yılınız: ");
            int yil=int.Parse (Console.ReadLine());
            int yas = 2023 - yil;
            Console.WriteLine("merhaba "+ ad+" "+ soyad +" siz "+ yas+ " yaşındasınız. ");

        }
    }
}
