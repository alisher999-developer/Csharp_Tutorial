// Algorithm for Finding the Minimum Value in C#

using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // The numbers to search
            int[] arr = { 1, 2, 3, 4, -5 };

            // Start by assuming the first element is the smallest
            int min = arr[0];

            // Go through every element in the array
            for (int i = 0; i < arr.Length; i++)
            {
                // If this element is smaller than the current minimum, it becomes the new minimum
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            // Print the result
            Console.WriteLine(min);
        }
    }
}
