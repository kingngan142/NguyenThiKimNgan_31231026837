using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiKimNgan_31231026837
{
    internal class Section_07
    {
        public static void Main()
        {
            Question_01();
            Question_01();

            Console.ReadKey();

        }
        public static void Question_01()
        {
            // 1. Create an integermatrix N x M (N,M was prompted from user) randomly.
            Console.Write("Enter the number of rows (N): ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns (M): ");
            int M = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, M];
            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = rand.Next(1, 101);
                }
            }

            // 2. Print the matrix 
            PrintMatrix(matrix);
            static void PrintMatrix(int[,] matrix)
            {
                Console.WriteLine("Matrix:");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            // 3. Print the ith row/column
            Console.Write("Enter the index (i) for row/column to print (1-based index): ");
            int index = int.Parse(Console.ReadLine()) - 1;  // Convert to 0-based index
            Console.Write("Would you like to print a row or column? (row/col): ");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "row")
            {
                PrintRow(matrix, index);
            }
            else if (choice.ToLower() == "col")
            {
                PrintColumn(matrix, index);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
            static void PrintRow(int[,] matrix, int row)
            {
                Console.WriteLine($"Row {row + 1}:");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[row, j] + "\t");
                }
                Console.WriteLine();
            }
            static void PrintColumn(int[,] matrix, int col)
            {
                Console.WriteLine($"Column {col + 1}:");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    Console.WriteLine(matrix[i, col]);
                }
            }

            // 4. Find the max value of the matrix
            int maxVal = FindMax(matrix);
            Console.WriteLine($"The maximum value in the matrix is: {maxVal}");
            static int FindMax(int[,] matrix)
            {
                int maxVal = matrix[0, 0];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] > maxVal)
                        {
                            maxVal = matrix[i, j];
                        }
                    }
                }
                return maxVal;
            }

            // 5. Find the minimum value of the matrix 
            Console.Write("Enter the index (i) for row/column to find min value (1-based index): ");
            index = int.Parse(Console.ReadLine()) - 1;  // Convert to 0-based index
            Console.Write("Would you like to find the min in a row or column? (row/col): ");
            choice = Console.ReadLine();
            if (choice.ToLower() == "row")
            {
                int minValRow = FindMinInRow(matrix, index);
                Console.WriteLine($"The minimum value in row {index + 1} is: {minValRow}");
            }
            else if (choice.ToLower() == "col")
            {
                int minValCol = FindMinInColumn(matrix, index);
                Console.WriteLine($"The minimum value in column {index + 1} is: {minValCol}");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
            static int FindMinInRow(int[,] matrix, int row)
            {
                int minVal = matrix[row, 0];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[row, j] < minVal)
                    {
                        minVal = matrix[row, j];
                    }
                }
                return minVal;
            }
            static int FindMinInColumn(int[,] matrix, int col)
            {
                int minVal = matrix[0, col];
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, col] < minVal)
                    {
                        minVal = matrix[i, col];
                    }
                }
                return minVal;
            }

            // 6. Transpose the matrix
            int[,] transposedMatrix = TransposeMatrix(matrix);
            Console.WriteLine("The transposed matrix is:");
            PrintMatrix(transposedMatrix);

            // 7. Print the main and secondary diagonals
            PrintDiagonals(matrix);
            static int[,] TransposeMatrix(int[,] matrix)
            {
                int N = matrix.GetLength(0);
                int M = matrix.GetLength(1);
                int[,] transposed = new int[M, N];

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        transposed[j, i] = matrix[i, j];
                    }
                }
                return transposed;
            }

            // 8. Print the main and secondary diagonals
            PrintDiagonals(matrix);
            static void PrintDiagonals(int[,] matrix)
            {
                int N = matrix.GetLength(0);
                int M = matrix.GetLength(1);

                Console.WriteLine("Main diagonal:");
                for (int i = 0; i < Math.Min(N, M); i++)
                {
                    Console.Write(matrix[i, i] + "\t");
                }
                Console.WriteLine();

                Console.WriteLine("Secondary diagonal:");
                for (int i = 0; i < Math.Min(N, M); i++)
                {
                    Console.Write(matrix[i, M - i - 1] + "\t");
                }
            }

        }
        public static void Question_02()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            // Get number of columns for each row (this can vary per row in a jagged array)
            int[] columns = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Enter the number of columns for row {i + 1}: ");
                columns[i] = int.Parse(Console.ReadLine());
            }

            // Create jagged array
            int[][] jaggedArray = new int[rows][];

            // Populate jagged array with random values or user input
            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new int[columns[i]];
                for (int j = 0; j < columns[i]; j++)
                {
                    Console.Write($"Enter value for element [{i + 1}, {j + 1}] (or press Enter for random): ");
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        // If the user just pressed Enter, fill with random number
                        jaggedArray[i][j] = new Random().Next(1, 101);  // Random number between 1 and 100
                    }
                    else
                    {
                        jaggedArray[i][j] = int.Parse(input);
                    }
                }
            }

            // Print the jagged array
            PrintJaggedArray(jaggedArray);

            // Call the functions for the required tasks
            PrintBiggestOfEachRowAndOverall(jaggedArray);
            SortRowsAscending(jaggedArray);
            PrintPrimeNumbers(jaggedArray);
            SearchAndPrintPositions(jaggedArray);
        }

        // Function to print the jagged array
        static void PrintJaggedArray(int[][] jaggedArray)
        {
            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Function to print the largest number in each row and the overall largest number in the array
        static void PrintBiggestOfEachRowAndOverall(int[][] jaggedArray)
        {
            int overallMax = int.MinValue;
            Console.WriteLine("\nBiggest number of each row:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int rowMax = int.MinValue;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] > rowMax)
                        rowMax = jaggedArray[i][j];
                    if (jaggedArray[i][j] > overallMax)
                        overallMax = jaggedArray[i][j];
                }
                Console.WriteLine($"Row {i + 1} biggest: {rowMax}");
            }
            Console.WriteLine($"Overall biggest number in the jagged array: {overallMax}");
        }

        // Function to sort each row in ascending order
        static void SortRowsAscending(int[][] jaggedArray)
        {
            Console.WriteLine("\nRows after sorting in ascending order:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Array.Sort(jaggedArray[i]);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Function to print all prime numbers in the jagged array
        static void PrintPrimeNumbers(int[][] jaggedArray)
        {
            Console.WriteLine("\nPrime numbers in the jagged array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (IsPrime(jaggedArray[i][j]))
                    {
                        Console.Write(jaggedArray[i][j] + "\t");
                    }
                }
            }
            Console.WriteLine();
        }

        // Function to check if a number is prime
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // Function to search and print all positions of a number entered by the user
        static void SearchAndPrintPositions(int[][] jaggedArray)
        {
            Console.Write("\nEnter a number to search for its positions: ");
            int searchValue = int.Parse(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] == searchValue)
                    {
                        Console.WriteLine($"Found {searchValue} at position [{i + 1}, {j + 1}]");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"The number {searchValue} was not found in the array.");
            }
        }
    }

}