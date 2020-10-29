using System;

namespace MaxSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] a = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int max = 0;
            int i = 0;
            int j = i + 1;
           
            int sum = maxSubArraySum(a, a.Length);
        }
        static int maxSubArraySum(int[] a,int size)
        {
            int max_so_far = 0,
                max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];
                if (max_ending_here < 0)
                    max_ending_here = 0;

                /* Do not compare for all 
            elements. Compare only  
            when max_ending_here > 0 */
                else if (  max_ending_here > max_so_far)
                    max_so_far = max_ending_here;
            }
            return max_so_far;
        }
    }
}
