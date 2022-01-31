using System;

namespace Generics
{
    internal class GenericClassForPrintArray<T>
    {
        private int[] arr;

        public GenericClassForPrintArray(int[] arr)
        {
            this.arr = arr;
        }

        internal void PrintElements()
        {
            throw new NotImplementedException();
        }
    }
}