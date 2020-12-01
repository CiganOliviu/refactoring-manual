using System;

namespace StartPoint
{
    class PrimeNumbers
    {
        private bool IsEqualWithTwo(int number)
        {
            return number == 2;
        }
        public bool IsPrimeNumber(int number)
        {
            if (IsEqualWithTwo(number))
                return true;

            for (int iterator = 2; iterator <= number / 2; iterator++)
                if (number % iterator == 0)
                    return false;

            return true;
        }
    }

    class SystemTests
    {
        private readonly PrimeNumbers _primeAttribute;

        public SystemTests()
        {
            _primeAttribute = new PrimeNumbers();
        }
        
        private static bool Assert(bool statement)
        {
            if (statement == false)
                throw new ArgumentException("Assertion failed");

            return true;
        }

        public void TestIsPrimeNumber()
        {
            Assert(_primeAttribute.IsPrimeNumber(13) == true);
            Assert(_primeAttribute.IsPrimeNumber(3) == true);
            Assert(_primeAttribute.IsPrimeNumber(26) == false);
            Assert(_primeAttribute.IsPrimeNumber(96) == false);
            
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            SystemTests tests = new SystemTests();
            
            tests.TestIsPrimeNumber();
        }
    }
}