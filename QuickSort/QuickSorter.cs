using System;
using System.Linq;

namespace QuickSort
{
    public class QuickSorter
    {
        public static void Main(string[] args)
        {
            var input = new int[] { 6, -5, 23, 3, 18000, 4, -12, 7 };
            var output = QuickSort(input);
            Console.WriteLine(String.Format("Input: [{0}]", string.Join(", ", input)));
            Console.WriteLine(String.Format("Output: [{0}]", string.Join(", ", output)));
            Console.ReadKey();
        }

        /// <summary>
        /// Performs a QuickSort given an unsorted array of integers.
        /// </summary>
        /// <param name="array">An unsorted array of integers</param>
        /// <returns>A sorted array of integers</returns>
        public static int[] QuickSort(int[] array)
        {
            // If there is only one thing, it's sorted!
            if (array.Length <= 1)
            {
                return array;
            }
            // Otherwise,
            else
            {
                // Choose the last number in the array as our pivot.
                var pivot = new int[] { array.Last() };

                // Recurse on everything lower than the pivot,
                var sortedLower = QuickSort(array.Where(x => x < pivot[0]).ToArray<int>());

                // Recurse on everything higher than the pivot,
                var sortedHigher = QuickSort(array.Where(x => x > pivot[0]).ToArray<int>());

                // Put them together!
                return sortedLower.Concat(pivot.Concat(sortedHigher)).ToArray();
            }
        }
    }
}
