using System;
using System.Diagnostics.CodeAnalysis;

namespace MeanMode
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
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
            int high = 0;
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
