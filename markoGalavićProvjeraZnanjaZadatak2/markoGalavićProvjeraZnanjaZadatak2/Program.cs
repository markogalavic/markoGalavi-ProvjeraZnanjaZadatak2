using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićProvjeraZnanjaZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            string unos;
            Console.WriteLine("Unesite tri različita broja");
            unos = Console.ReadLine();
            a = Convert.ToInt32(unos.Substring(0,2));
            b = Convert.ToInt32(unos.Substring(3,5));
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b || a > c)
            {
                Console.WriteLine("Najveći broj je" + a);
            }
            if (b > a || b > c)
            {
                Console.WriteLine("Najveći broj je" + b);
            }
            if (c > a || c > b)
            {
                Console.WriteLine("Najveći broj je" + c);
            }
            Console.ReadKey();
        }
    }
}
