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

            double rezultats = Funkcija2();
            Console.WriteLine(rezultats);
        

        
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

    }
}
