namespace EndPoint
{
    public class ArrayProcessorObject
    {
        public int GetMaxFromArray(OneDimensionalArray array)
        {
            int result = array.GetOneDimensionalArray()[0];

            for (int iterator = 0; iterator < array.GetLength(); iterator++)
                result = result < array.GetOneDimensionalArray()[iterator] ? array.GetOneDimensionalArray()[iterator] : result;
            
            return result;
        }

        public int GetMinFromArray(OneDimensionalArray array)
        {
            int result = array.GetOneDimensionalArray()[0];

            for (int iterator = 0; iterator < array.GetLength(); iterator++)
                result = result > array.GetOneDimensionalArray()[iterator] ? array.GetOneDimensionalArray()[iterator] : result;
            
            return result;
        }
        
        public bool IsValueInArray(OneDimensionalArray array, int valueToSearch)
        {
            for (int iterator = 0; iterator < array.GetLength(); iterator++)
                if (array.GetOneDimensionalArray()[iterator] == valueToSearch)
                    return true;
            
            return false;
        }    
    }
}