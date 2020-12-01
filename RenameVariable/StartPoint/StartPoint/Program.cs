using System;

namespace StartPoint
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

        public void SetOneDimensionalArray(int[] newArray)
        {
            this._oneDimensionalArray = newArray;
        }
        public int[] GetOneDimensionalArray()
        {
            return this._oneDimensionalArray;
        }
    }

    class SearchProcessor
    {
        public bool IsValueInArray(OneDimensionalArray array, int n)
        {
            for (int iterator = 0; iterator < array.GetLength(); iterator++)
                if (array.GetOneDimensionalArray()[iterator] == n)
                    return true;

            return false;
        }
    }

    class SystemTests
    {
        private readonly OneDimensionalArray _array;
        private readonly SearchProcessor _processor;

        public SystemTests()
        {
            _array = new OneDimensionalArray();
            _array.SetLength(7);
            _array.SetOneDimensionalArray(new[] {12, -12, 57, 32, -321, 13, 0});

            _processor = new SearchProcessor();
        }

        private static bool Assert(bool statement)
        {
            if (statement == false)
                throw new ArgumentException("Assertion failed");

            return true;
        }

        public void TestIsValueInArray()
        {
            Assert(_processor.IsValueInArray(_array, 13));
            Assert(_processor.IsValueInArray(_array, -12));
            Assert(_processor.IsValueInArray(_array, 123) == false);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SystemTests tests = new SystemTests();

            tests.TestIsValueInArray();
        }
    }
}
