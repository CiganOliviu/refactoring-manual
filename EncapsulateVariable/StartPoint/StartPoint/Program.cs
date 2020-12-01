using System;

namespace StartPoint
{
    class OneDimensionalArray
    {
        public int length;
        public int[] oneDimensionalArray = {};
    }

    class Program
    {
        static void Main(string[] args)
        {
            OneDimensionalArray array = new OneDimensionalArray();
            array.length = 5;

            // array = ReadOneDimensionalArray(array.length);
        }
    }
}
