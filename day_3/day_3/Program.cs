using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funkcija();
            Funkcija3(5,6);
            Funkcija3(99, 22);

            double rezultats = Funkcija2();
            Console.WriteLine(rezultats);
            int rezultats1 = Funkcija4(3, 6);
            Console.WriteLine(rezultats1);

            Console.ReadLine();

        }

        static void Funkcija()
        {
            int a, b, c;
            a = 5;
            b = 6;
            c = a + b;
            Console.WriteLine(c);
          
        }
        static double Funkcija2()
        {
            double a, b, c;
            a = 6.5;
            b = 4.7;
            c = a + b;

            return c;
              
        }
        static void Funkcija3(int skaitlis1, int skaitlis2)
        {
            int c = skaitlis1 + skaitlis2;
            Console.WriteLine(c);

        }
        static int Funkcija4(int skaitlis3, int skaitlis4)
        {
            int c = skaitlis3 + skaitlis4;
            return c;

        }

    }
}
