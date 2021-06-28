using System;

namespace Arraytrial
{
    class Program
    {
        static void Main()
        {
            // Declare a single-dimensional array of 5 integers.
            int n = 5;
            int[] array1 = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(array1[i]);
            }

            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
        }
    }
}
