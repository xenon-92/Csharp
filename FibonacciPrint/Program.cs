using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length");
            int n = Convert.ToInt32(Console.ReadLine());
            int a, b, c;

            for (int i = 1; i < n; i++)
            {
                            b = 0;
            c = 1;
                for (int j = 1; j <= i; j++)
                {
                    a = b;
                    b = c;
                    c = a + b;
                    Console.Write(a+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
