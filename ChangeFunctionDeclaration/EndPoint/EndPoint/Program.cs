using System;

namespace EndPoint
{
    class NumberProcessor
    {
        public int GetSumOfDigits(int number)
        {
            int result = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                result += lastDigit;
                
                number /= 10;
            }
            
            return result;
        }
    }

    class SystemTests
    {
        private readonly NumberProcessor _processor;

        public SystemTests()
        {
            _processor = new NumberProcessor();
        }
        
        private static bool Assert(bool statement)
        {
            if (statement == false)
                throw new ArgumentException("Assertion failed");

            return true;
        }

        public void TestGetSumOfDigits()
        {
            Assert(_processor.GetSumOfDigits(1234) == 10);
            Assert(_processor.GetSumOfDigits(99) == 18);
            Assert(_processor.GetSumOfDigits(10) == 1);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            SystemTests tests = new SystemTests();
            
            tests.TestGetSumOfDigits();
        }
    }
}