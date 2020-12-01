using System;
using System.Linq.Expressions;

namespace ExtractFunctionGoodExample
{

    class LimitsOfArray
    {

        public static int GetMaxFromArray(int length, int[] array)
        {
            int result = array[0];

            for (int iterator = 0; iterator < length; iterator++)
                if (result < array[iterator])
                    result = array[iterator];
            
            return result;
        }

        public static int GetMinFromArray(int length, int[] array)
        {
            int result = array[0];

            for (int iterator = 0; iterator < length; iterator++)
                if (result > array[iterator])
                    result = array[iterator];

            return result;
        }
    }

    class SystemTests
    {
        private LimitsOfArray limits;

        private static bool Assert(bool statement)
        {
            if (statement == false)
                throw new ArgumentException("Assertion failed");

            return true;
        }
        
        public SystemTests()
        {
            limits = new LimitsOfArray();    
        }

        public void TestGetMaxFromArray()
        {
            Assert(LimitsOfArray.GetMaxFromArray(5, new int[] {1, 2, 3, 4, 5}) == 5);
            Assert(LimitsOfArray.GetMaxFromArray(7, new int[] {12, -12, 31, 15, 16, 7, -32}) == 31);
        }

        public void TestGetMinFromArray()
        {
            Assert(LimitsOfArray.GetMinFromArray(5, new int[] {1, 2, 3, 4, 5}) == 1);
            Assert(LimitsOfArray.GetMinFromArray(7, new int[] {12, -12, 31, 15, 16, 7, -32}) == -32);
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