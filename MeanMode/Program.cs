using System;

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
            return 0.0;
        }

        // TODO
        private static double? ComputeMode(int[] array)
        {
            return null;
        }
    }
}
