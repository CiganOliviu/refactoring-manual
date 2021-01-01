using System;
using System.Linq;

namespace EndPoint
{
    class OneDimensionalArray
    {
        private int[] _array;
        
        private int[] GetSliceOf(int[] array)
        {
            int[] result = new int[array.Length];

            for (int it = 0; it < array.Length; it++)
                result[it] = array[it];
            
            return result;
        }
        
        public int[] GetOneDimensionalArray()
        {
            return GetSliceOf(this._array);
        }
        
        public void SetElementOfOneDimensionalArray(int value, int position)
        {
            this._array[position] = value;
        }

        public int GetElementOfOneDimensionalArray(int position)
        {
            return this._array[position];
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}