using System;

namespace MyAlgorithms
{
    public class MyAlgorithms
    {
        /// <summary>
        /// Sorts an integer array in ascending order using the Selection Sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>
        /// The sorted integer array in ascending order It iterates through the array, 
        /// finding the smallest element and moving it to the front, 
        /// repeating this process for the remaining unsorted portion of the array.
        /// </returns>
        /// <remarks>
        /// repeating this process for the remaining unsorted portion of the array
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the input array is null">
        /// </exception>
        public static int[] SelectionSort(int[] numbers)
        {
            int numberLength = numbers.Length;

            for (int i = 0; i < numberLength - 1; i++)
            {
                for (int j = i + 1; j < numberLength; j++)
                {
                    if(numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
