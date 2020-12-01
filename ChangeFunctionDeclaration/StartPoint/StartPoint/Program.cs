using System;

namespace StartPoint
{
    class NumbersProcessor
    {
        public void Sum(int n, ref int sum)
        {
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
        }     
    }

    class SystemTests
    {
        private readonly NumbersProcessor _processor;

        public SystemTests()
        {
            _processor = new NumbersProcessor();
        }
        
        private static bool Assert(bool statement)
        {
            if (statement == false)
                throw new ArgumentException("Assertion failed");

            return true;
        }

        public void TestSum()
        {
            int sum = 0;
            _processor.Sum(1234, ref sum);
            Assert(sum == 10);

            sum = 0;
            _processor.Sum(99, ref sum);
            Assert(sum == 18);
            
            sum = 0;
            _processor.Sum(10, ref sum);
            Assert(sum == 1);
            
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            SystemTests tests = new SystemTests();
            
            tests.TestSum();
        }
    }
}
