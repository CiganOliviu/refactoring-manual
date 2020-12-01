using System;

namespace EndPoint
{
    class NumberProcessor
    {
        public int ReverseNumber(int number)
        {
            int result = 0;

            while (number > 0)
            { 
                int lastDigit = number % 10;
                result = result * 10 + lastDigit;
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

        public void TestReverseNumber()
        {
            Assert(_processor.ReverseNumber(1234) == 4321);
            Assert(_processor.ReverseNumber(1203) == 3021);
            Assert(_processor.ReverseNumber(9898) == 8989);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            SystemTests tests = new SystemTests();
            
            tests.TestReverseNumber();
        }
    }
}