namespace StartPoint
{
    public class SearchProcessor
    {
        public bool IsValueInArray(OneDimensionalArray array, int valueToSearch)
        {
            for (int iterator = 0; iterator < array.GetLength(); iterator++)
                if (array.GetOneDimensionalArray()[iterator] == valueToSearch)
                    return true;
            
            return false;
        }    
    }
}