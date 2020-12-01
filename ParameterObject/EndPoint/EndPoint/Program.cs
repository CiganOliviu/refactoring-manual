using System;
using System.Linq;

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

        public void SetOneDimensionalArray(int[] newArray)
        {
            this._oneDimensionalArray = newArray;
        }
        public int[] GetOneDimensionalArray()
        {
            return this._oneDimensionalArray;
        }
    }

    class SortProcessor
    {
        private void InterchangeValues(ref int firstElement, ref int secondElement)
        {
            firstElement = firstElement + secondElement;
            secondElement = firstElement - secondElement;
            firstElement = firstElement - secondElement;
            
        }
        
        public int[] SortByBubbles(OneDimensionalArray array)
        {
            for (int iterator = 0; iterator < array.GetLength() - 1; iterator++)
                for (int jiterator = iterator + 1; jiterator < array.GetLength(); jiterator++)
                    if (array.GetOneDimensionalArray()[iterator] > array.GetOneDimensionalArray()[jiterator])
                        InterchangeValues(ref array.GetOneDimensionalArray()[iterator], ref array.GetOneDimensionalArray()[jiterator]);

            return array.GetOneDimensionalArray();
        }   
    }
    
    class SystemTests
    {
        private readonly OneDimensionalArray _arraySetOne;
        private readonly OneDimensionalArray _arraySetTwo;
        private readonly OneDimensionalArray _arraySetThree;
        
        private readonly SortProcessor _processor;
        
        public SystemTests()
        {
            _arraySetOne = new OneDimensionalArray();
            _arraySetOne.SetLength(5);
            _arraySetOne.SetOneDimensionalArray(new int[] {5, 4, 3, 2, 1});
            
            _arraySetTwo = new OneDimensionalArray();
            _arraySetTwo.SetLength(3);
            _arraySetTwo.SetOneDimensionalArray(new int[] {-12, -13, -14});
            
            _arraySetThree = new OneDimensionalArray();
            _arraySetThree.SetLength(7);
            _arraySetThree.SetOneDimensionalArray(new int[] {12, -12, 57, 32, -321, 13, 0});
            
            _processor = new SortProcessor();
        }

        private static bool Assert(bool statement)
        {
            if (statement == false)
                throw new ArgumentException("Assertion failed");

            return true;
        }
        
        public void TestSortByBubbles()
        {
            Assert(_processor.SortByBubbles(_arraySetOne).SequenceEqual(new int[] {1, 2, 3, 4, 5}));
            Assert(_processor.SortByBubbles(_arraySetTwo).SequenceEqual(new int[] {-14, -13, -12}));
            Assert(_processor.SortByBubbles(_arraySetThree).SequenceEqual(new int[] {-321, -12, 0, 12, 13, 32, 57}));
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            SystemTests tests = new SystemTests();
            
            tests.TestSortByBubbles();
        }
    }
}