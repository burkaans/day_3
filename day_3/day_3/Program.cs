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

            string rezultats2;
            rezultats2 = Funkcija5("es ","tu ","mes" );
            Console.WriteLine(rezultats2 +" un viss kopaa");

            string var1, var2, var3;
            var1 = Console.ReadLine();
            var2 = Console.ReadLine();
            var3 = Console.ReadLine();
            string rezultats4 = Funkcija5(var1, var2, var3);
            Console.WriteLine(rezultats4);
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
        static int Funkcija4(int skaitlis1, int skaitlis2)
        {
            int c = skaitlis1 + skaitlis2;
            return c;

        }
        static string Funkcija5(string vards1, string vards2, string vards3)
        {
            string result = vards1 + vards2 + vards3;
            return result;

        }

    }
}
