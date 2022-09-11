using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class UsingGenericArray
    {
        public void usingGeneric()
        {
            int[] intArr = {1, 2, 3, 4, 5};
            double[] doubleArr = {1.1, 2.2, 3.3, 4.4, 5.5};
            char[] charArr = {'a', 'b', 'c', 'd', 'e'};
            PrintArr<int>(intArr);
            PrintArr<double>(doubleArr);
            PrintArr<char>(charArr);
        }
        static void PrintArr<T>(T[] arr)
        {
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
