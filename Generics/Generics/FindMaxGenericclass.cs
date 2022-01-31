using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     public class FindMaxGenericclass<T> where T : IComparable
    {
        public T first, second, third;

        private FindMaxGenericclass(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        private static T FindMaxValueOutofThree(T first, T second, T third)
        {
            //result will be either 0 or 1 or -1
            int res = first.CompareTo(second);
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;

            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {

                Console.WriteLine("either 2 or 3 numbers having same value/equal");
                return default;
            }
        }
        public void MaxTest()
        {
            FindMaxValueOutofThree(first, second, third);
        

        }
    }
}


