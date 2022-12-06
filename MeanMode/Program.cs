using System;
using System.Collections.Generic;
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

       
        private static double? ComputeMode(int[] array)
        {
            // using dictionary instead
            Dictionary<int, int> count = new Dictionary<int, int>();
            
            foreach (int a in array)
            {
                
                if (count.ContainsKey(a))
                {
                    count[a] = count[a] + 1;
                }

                else
                {
                    count[a] = 1;
                }
                   
            }
            int result = int.MinValue;
            int maximum = int.MinValue;
            foreach (int key in count.Keys)
            {
                if (count[key] >= maximum)
                {
                    maximum = count[key];
                    result = key;
                }
            }
            return result;
        }
    }
}
