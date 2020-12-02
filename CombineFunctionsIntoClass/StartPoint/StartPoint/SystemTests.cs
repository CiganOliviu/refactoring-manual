using System;

namespace StartPoint
{
    public class SystemTests
    {
        private readonly OneDimensionalArray _arraySetOne;
        private readonly OneDimensionalArray _arraySetTwo;
        
        private readonly SearchProcessor _searchProcessor;
        private readonly LimitsOfArray _limitsOfArray;

        public SystemTests()
        {
            _arraySetOne = new OneDimensionalArray();
            _arraySetOne.SetLength(7);
            _arraySetOne.SetOneDimensionalArray(new[] {12, -12, 57, 32, -321, 13, 0});
            
            _arraySetTwo = new OneDimensionalArray();
            _arraySetTwo.SetLength(7);
            _arraySetTwo.SetOneDimensionalArray(new[] {12, -12, 31, 15, 16, 7, -32});
            
            _searchProcessor = new SearchProcessor();
            _limitsOfArray = new LimitsOfArray();
        }
        private bool Assert(bool statement)
        {
            if (statement == false)
                throw  new ArgumentException("Assertion failed");

            return true;
        }
        
        public void TestIsValueInArray()
        {
            Assert(_searchProcessor.IsValueInArray(_arraySetOne, 13));
            Assert(_searchProcessor.IsValueInArray(_arraySetOne, -12));
            Assert(_searchProcessor.IsValueInArray(_arraySetOne, 123) == false);
        }

        public void TestGetMaxFromArray()
        {
            Assert(_limitsOfArray.GetMaxFromArray(_arraySetOne) == 57);
            Assert(_limitsOfArray.GetMaxFromArray(_arraySetTwo) == 31);
        }
        
        public void TestGetMinFromArray()
        {
            Assert(_limitsOfArray.GetMinFromArray(_arraySetOne) == -321);
            Assert(_limitsOfArray.GetMinFromArray(_arraySetTwo) == -32);
        }
    }
}