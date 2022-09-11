using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintArray             
    {
        public void createArray()         
        {
            int[] intArr = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArr = { 0.1, 0.2, 0.3, 0.4, 0.5 };
            char[] charArr = { 'a', 'b', 'c', 'd', 'e', 'f' };

            PrintIntArr(intArr);              
            PrintDoubleArr(doubleArr);
            PrintCharArr(charArr);
        }
        static void PrintIntArr(int[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
        static void PrintDoubleArr(double[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
        static void PrintCharArr(char[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
