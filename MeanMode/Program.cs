using System;
using System.Diagnostics.CodeAnalysis;

namespace MeanMode
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 4;
            numbers[2] = 4;
            numbers[3] = 6;
            numbers[4] = 2;
            Console.WriteLine(MeanMode(numbers));
            

        }

        public static bool MeanMode(int[] array)
        {
            return ComputeMode(array) == ComputeAverage(array);
        }

        // TODO
        private static double ComputeAverage(int[] array)
        {
          double  sum = 0.0;
          
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double avg = sum / array.Length;
            return avg;
        }

        // TODO
        private static double? ComputeMode(int[] array)
        {
            double high = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
               
                if (array[i] > high)
                {
                    high = array[i];
                    
                }

            }
            return high;
        }
    }
}
