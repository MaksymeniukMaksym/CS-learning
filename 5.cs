using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 5, 7, 9 };
            Console.WriteLine("Виконуємо пошук числа 5: {0}", BinarySearch(a, 5));

            Console.ReadLine();
        }

 
        private static int? BinarySearch(int[] a, int x)
        {

            if ((a.Length == 0) || (x < a[0]) || (x > a[a.Length - 1]))
                return null;


            int first = 0;

            int last = a.Length;


            while (first < last)
            {
                int mid = first + (last - first) / 2;

                if (x <= a[mid])
                    last = mid;
                else
                    first = mid + 1;
            }

 
            if (a[last] == x)
                return last;
            else
                return null;
        }
    }
}