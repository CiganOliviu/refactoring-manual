namespace StartPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemTests tests = new SystemTests();
            
            tests.TestIsValueInArray();
            
            tests.TestGetMaxFromArray();
            tests.TestGetMinFromArray();
        }
    }
}