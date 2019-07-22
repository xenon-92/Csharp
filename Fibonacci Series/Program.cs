using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length");
            int n = Convert.ToInt32(Console.ReadLine());
            //int[] fibonacci = new int[n-1];
            //int a = 0;
            //int b = 1;
            //int add = 0;
            //for (int i = 1; i < n-1; i++)
            //{
            //    add = a + b;
            //    fibonacci[i] = b;
            //    a = b;
            //    b = add;
            //}
            // Console.ReadLine();
            int a, b, c;
            b = 0;
            c = 1;
            for(int i = 1; i <= n; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.Write(a + " ");
            }
            Console.ReadLine();
        }
    }
}
