using System;
using System.Linq;

namespace StartPoint
{
    class SortProcessor
    {
        private void InterchangeValues(ref int firstElement, ref int secondElement)
        {
            firstElement = firstElement + secondElement;
            secondElement = firstElement - secondElement;
            firstElement = firstElement - secondElement;
            
        }
        
        public int[] SortByBubbles(int length, int[] oneDimensionalArray)
        {
            for (int iterator = 0; iterator < length - 1; iterator++)
                for (int jiterator = iterator + 1; jiterator < length; jiterator++)
                    if (oneDimensionalArray[iterator] > oneDimensionalArray[jiterator])
                        InterchangeValues(ref oneDimensionalArray[iterator], ref oneDimensionalArray[jiterator]);

            return oneDimensionalArray;
        }
    }

    class SystemTests
    {
        private readonly SortProcessor _processor;
        
        public SystemTests()
        {
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
            Assert(_processor.SortByBubbles(5, new int[] {5, 4, 3, 2, 1}).SequenceEqual(new int[] {1, 2, 3, 4, 5}));
            Assert(_processor.SortByBubbles(3, new int[] {-12, -13, -14}).SequenceEqual(new int[] {-14, -13, -12}));
            Assert(_processor.SortByBubbles(7, new int[] {12, -12, 57, 32, -321, 13, 0}).SequenceEqual(new int[] {-321, -12, 0, 12, 13, 32, 57}));
            
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