using System;
using System.IO;

namespace StartPoint
{
    class OneDimensionalArray
    {
        private int _length;
        private readonly int[] _array = {};

        public void SetLength(int length)
        {
            this._length = length;
        }
        
        public int GetLength()
        {
            return this._length;
        }

        public int[] GetArray()
        {
            return this._array;
        }
    }

    class ValidatorObject
    {
        public void ValidateLengthOfArray(OneDimensionalArray array)
        {
            int length = array.GetLength();

            if (length < 0)
                throw new InvalidDataException("Unable to process negative length for array");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // pass
        }
    }
}