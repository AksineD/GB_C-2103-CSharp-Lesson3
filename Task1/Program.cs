// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Task1
{
    #region

    using System;

    #endregion

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The fill array with random.
        /// </summary>
        /// <param name="array">
        /// The array.
        /// </param>
        /// <param name="arrSize">
        /// The arr size.
        /// </param>
        private static void FillArrayWithRandom(ref int[,] array, int arrSize)
        {
            var randNum = new Random();
            for (var i = 0; i < arrSize; i++)
                for (var j = 0; j < arrSize; j++)
                    array[i, j] = randNum.Next(0, 101);
        }

        /// <summary>
        /// The get user input.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private static int GetUserInput()
        {
            if (int.TryParse(Console.ReadLine(), out var result)) return result;

            Console.WriteLine("Enter a valid value");

            return GetUserInput();
        }

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            var arrSize = GetUserInput();
            var array = new int[arrSize, arrSize];

            FillArrayWithRandom(ref array, arrSize);

            PrintArray(array, arrSize);

            Console.WriteLine();
            PrintArrayDiagonal(array, arrSize);
        }

        /// <summary>
        /// The print array.
        /// </summary>
        /// <param name="array">
        /// The array.
        /// </param>
        /// <param name="arrSize">
        /// The arr size.
        /// </param>
        private static void PrintArray(int[,] array, int arrSize)
        {
            Console.WriteLine("Source array filled with generated pseudo-random numbers from 0 to 100");
            for (var i = 0; i < arrSize; i++)
            {
                for (var j = 0; j < arrSize; j++) Console.Write("{0, 3}", array[i, j]);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// The print array diagonal.
        /// </summary>
        /// <param name="array">
        /// The array.
        /// </param>
        /// <param name="arrSize">
        /// The arr size.
        /// </param>
        private static void PrintArrayDiagonal(int[,] array, int arrSize)
        {
            Console.WriteLine("Main diagonal of the array");
            for (var i = 0; i < arrSize; i++)
            {
                for (var j = 0; j < arrSize; j++)
                    if (i == j) Console.Write("{0, 3}", array[i, j]);
                    else Console.Write("{0, 3}", " ");
                Console.WriteLine();
            }
        }
    }
}