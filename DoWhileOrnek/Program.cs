using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = new Random().Next(0, 100);
            int tahmin = 0;
            do
            {
                Console.WriteLine("Tuttuğum sayıyı tahmin et.");
                tahmin = int.Parse(Console.ReadLine());
                if (tahmin > sayi)
                {
                    Console.WriteLine("Aşağı in");
                }
                else if (tahmin < sayi)
                    Console.WriteLine("Yukarı çık");
            } while (tahmin != sayi);
            Console.WriteLine("Tebrikler!");
            Console.ReadKey();
        }
    }
}
