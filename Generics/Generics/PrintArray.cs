using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintArray
    {
        public static void toprint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }

        }

        internal static void PrintElements(int[] arr)
        {
            throw new NotImplementedException();
        }

        internal static void PrintElements(double[] doubleArr)
        {
            throw new NotImplementedException();
        }

        internal static void PrintElements(char[] charArr)
        {
            throw new NotImplementedException();
        }
    }
}