using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введiть кiлькiсть грошової одиниці вiд 1 до 999");
            string input = Console.ReadLine();
            int count = Convert.ToInt32(input);
            if (count >= 20) 
            {
                count = count % 10;

            }
            if (count >= 5 && count <= 20)
            {
                Console.WriteLine(input + " " + "гривень");
            }
            else if (count >= 2 && count <= 4)
            {
                Console.WriteLine(input + " " + "гривнi");
            }
            else if (count == 1)
           {
                Console.WriteLine(input + " " + "гривня");
            }
            else
            {
                Console.WriteLine(input + " " + "гривень");
            }
            
       
        }
    }
}