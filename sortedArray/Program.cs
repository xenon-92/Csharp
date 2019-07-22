using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 3, 5, 7 };
            int[] arr2 = new int[] { 2, 4, 6, 8, 10 };
            int[] arr3 = new int[arr1.Length + arr2.Length];

            int i, j, k;

            i = j = k = 0;

            while (k < arr3.Length)
            {
                if (i < arr1.Length && j < arr2.Length)
                {
                    if (arr1[i] <= arr2[j])
                    {
                        arr3[k] = arr1[i];
                        k++;
                        i++;
                    }
                    else
                    {
                        arr3[k] = arr2[j];
                        k++;
                        j++;
                    }
                }
                else
                {
                    while(i < arr1.Length)
                    {
                        arr3[k] = arr1[i];
                        k++;
                        i++;
                    }
                    while(j < arr2.Length)
                    {
                        arr3[k] = arr2[j];
                        k++;
                        j++;
                    }
                }
            }

            foreach(int item in arr3)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
