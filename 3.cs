using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Визначення мiнiмального числа в послiдовностi додатнiх чисел." +
                Environment.NewLine +
                "Ведiть пiсля стрiлки числа.Для завершення введення введiть нуль");

            int numb = 99999999;

            while(numb > 0)
            {

                Console.Write("-> ");
                int numb_2 = Convert.ToInt32(Console.ReadLine());
                if (numb_2 == 0)
                {
                    break;
                }
                if (numb_2 < numb)
                {

                    numb = numb_2;

                }



            } 
            Console.WriteLine("Мiнiмальне число : " + numb);
        }
    }
}