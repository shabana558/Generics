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
            int[] arr = { 10, 20, 30, 40 };
            double[] doubleArr = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArr = { 'H', 'A', 'I', 'I' };
            Console.WriteLine("please enter single alphabet character");
            //Console.WriteLine(ASCII value is: {0}",console.Read"());//
            Console.WriteLine("please choose a program to execute");
            Console.WriteLine("1.Print Arry elements without generic concept.\n 2.Displaying array elements using generic method concept.\n 3.Generic class concept for printing an array.\n 4.Finding maximum value.\n 5.Exit program\n 6.Find max Generic class");
            Console.ReadLine();
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //PrintArray.PrintElements(arr);

                    //PrintArray.PrintElements(doubleArr);
                    //PrintArray.PrintElements(charArr);
                    break;
                case 2:
                //Console.WriteLine("\nDisplaying array elements using generic method concept");
                //GenericsMethodForPrintArray.printElements<int>(arr);
                //GenericsMethodForPrintArray.PrintElements<double>(doubleArr);
                //GenericsMethodForPrintArray.printElements<char>(charArr);
                //break;

                case 3:
                //Console.WriteLine("Generic class concept for printing an array");
                //new GenericClassForPrintArray<int>(arr).PrintElements();
                //new GenericClassForPrintArray<double>(arr).PrintElements();
                //new GenericClassForPrintArray<char>(arr).PrintElements();
                case 4:
                    int x = 60, y = 30, z = 20;
                    double p = 12.46, q = 43.33, r = 77.23;
                    string s = "abc", s1 = "pqr", s2 = "xyz";

                    if (FindMax.FindMaxvalueofthree(x, y, z) != 0)
                        Console.WriteLine("{0} is maximum out of {1},{2},{3}", FindMax.FindMaxvalueofthree(x, y, z), x, y, z);
                    if (FindMax.FindMaxvalueofthree(p, q, r) != 0.0)
                        Console.WriteLine("{0} is maximum out of {1},{2},{3}", FindMax.FindMaxvalueofthree(p, q, r), p, q, r);
                    if (FindMax.FindMaxvalueofthree(x, y, z) != null)
                        Console.WriteLine("{0} is maximum out of {1},{2},{3}", FindMax.FindMaxvalueofthree(s, s1, s2), s, s1, s2);

                    break;
                case 5:
                    break;
                case 6:
                    int T1 = 80, T2 = 40, T3 = 50;
                    FindMaxGeneric Genericclass<int> (T1, T2, T3).MaxTest();
                    Console. WriteLine("Max Value " + "");

                default:
                    break;
            }
                 Console.ReadLine();




        }
    }
}



        
    
