using System;

namespace StartPoint
{

    class LimitsOfArray
    {
        public void GetMaxAndMinFromArray(int length, int[] array, ref int max, ref int min)
        {

            max = array[0];
            min = array[0];
            
            for (int iterator = 0; iterator < length; iterator++)
            {
                if (max < array[iterator])
                    max = array[iterator];

                if (min > array[iterator])
                    min = array[iterator];
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {    
            LimitsOfArray limits = new LimitsOfArray();
            
            int max = 0;
            int min = 0;

            limits.GetMaxAndMinFromArray(5, new int[] {1, 2, 3, 4, 5}, ref max, ref min);
            
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}