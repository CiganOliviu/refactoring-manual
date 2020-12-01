using System;

namespace EndPoint
{
    class LimitsOfArray
    {
        public int GetMaxFromArray(int length, int[] array)
        {
            int result = array[0];

            for (int iterator = 0; iterator < length; iterator++)
                result = result < array[iterator] ? array[iterator] : result;
            
            return result;
        }

        public int GetMinFromArray(int length, int[] array)
        {
            int result = array[0];

            for (int iterator = 0; iterator < length; iterator++)
                result = result > array[iterator] ? array[iterator] : result;

            return result;
        }
    }

    class SystemTests
    {
        private readonly LimitsOfArray _limits;

        private static bool Assert(bool statement)
        {
            if (statement == false)
                throw new ArgumentException("Assertion failed");

            return true;
        }
        
        public SystemTests()
        {
            _limits = new LimitsOfArray();    
        }
        
        public void TestGetMaxFromArray()
        {
            Assert(_limits.GetMaxFromArray(5, new int[] {1, 2, 3, 4, 5}) == 5);
            Assert(_limits.GetMaxFromArray(7, new int[] {12, -12, 31, 15, 16, 7, -32}) == 31);
        }

        public void TestGetMinFromArray()
        {
            Assert(_limits.GetMinFromArray(5, new int[] {1, 2, 3, 4, 5}) == 1);
            Assert(_limits.GetMinFromArray(7, new int[] {12, -12, 31, 15, 16, 7, -32}) == -32);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {    
            SystemTests tests = new SystemTests();
            
            tests.TestGetMaxFromArray();
            tests.TestGetMinFromArray();
        }
    }
}