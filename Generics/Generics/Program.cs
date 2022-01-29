using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'A', 'I','I' };

            PrintArray.toprint<int>(intArray);
            PrintArray.toprint<double>(doubleArray);
            PrintArray.toprint<char>(charArray);

        }
    }
}