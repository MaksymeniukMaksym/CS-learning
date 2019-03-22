using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, n, h, S, x, f;
            Console.WriteLine("Введiть початкове  значення функцiї та натиснiть Enter  " );
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть кiнцеве значення функцiї та натиснiть Enter");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть частин на якi подiлена трапецiя та натиснiть Enter ");
            n = Convert.ToDouble(Console.ReadLine());
            if (a < b)
            {
                h = (b - a) / n;
                S = 0;
                x = a + h;
                for (; x < b;)
                {
                    f = x;
                    S = S + f;
                    x = x + h;
                }
                S = (h / 2) * (a + b + 2 * S);
                Console.WriteLine("Площа обчислювальної криволiнiйної трапецiї дорiвнює :" + S);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
