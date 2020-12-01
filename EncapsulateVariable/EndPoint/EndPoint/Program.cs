using System;

namespace EndPoint
{
    class OneDimensionalArray
    {
        private int length;
        private int[] _oneDimensionalArray = { };

        public void SetLength(int newLength)
        {
            this.length = newLength;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int[] GetOneDimensionalArray()
        {
            return this._oneDimensionalArray;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            OneDimensionalArray array = new OneDimensionalArray();
            
            array.SetLength(5);
            
            // array.ReadOneDimensionalArray(array.GetLength());
        }
    }
}