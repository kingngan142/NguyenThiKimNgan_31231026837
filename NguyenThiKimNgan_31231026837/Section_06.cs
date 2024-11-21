using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiKimNgan_31231026837
{
    internal class Section_06
    {
        public static void Main1()
        {
            {
                Question_01();
                Question_02();

                Console.ReadKey();
            }
            public static void Question_01()
            {
                Console.Write("Enter the number of items in the array: ");
                int N = int.Parse(Console.ReadLine());

                int[] array = new int[N];

                for (int i = 0; i < N; i++)
                {
                    Console.Write($"Enter value for item {i + 1}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nArray values:");
                PrintArray(array);

                IncreaseArrayByTwo(array);

                Console.WriteLine("\nArray values after increasing each item by 2:");
                PrintArray(array);

                int sum = CalculateSum(array);
                Console.WriteLine($"\nSum of array items: {sum}");

                double avg = CalculateAverage(array);
                int min = FindMin(array);
                int max = FindMax(array);

                Console.WriteLine($"Average value: {avg}");
                Console.WriteLine($"Minimum value: {min}");
                Console.WriteLine($"Maximum value: {max}");
            }

            static void PrintArray(int[] array)
            {
                foreach (int item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            static void IncreaseArrayByTwo(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] += 2;
                }
            }

            static int CalculateSum(int[] array)
            {
                int sum = 0;
                foreach (int item in array)
                {
                    sum += item;
                }
                return sum;
            }

            static double CalculateAverage(int[] array)
            {
                int sum = CalculateSum(array);
                return (double)sum / array.Length;
            }

            static int FindMin(int[] array)
            {
                int min = array[0];
                foreach (int item in array)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            }

            static int FindMax(int[] array)
            {
                int max = array[0];
                foreach (int item in array)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }
                return max;
            }
        }

        public static void Question_02()
        {
            // Create a random integer values array (for example, size 10, range 1 to 100)
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);  // Random integer between 1 and 100
            }

            // Display the original array
            Console.WriteLine("Original Array: " + string.Join(", ", array));

            // 1. Calculate the average value of the array elements
            double average = CalculateAverage(array);
            Console.WriteLine($"Average value: {average}");

            // 2. Test if the array contains a specific value
            int valueToTest = 50;  // Example value to test
            bool contains = ContainsValue(array, valueToTest);
            Console.WriteLine($"Array contains {valueToTest}: {contains}");

            // 3. Find the index of an array element
            int index = FindIndex(array, valueToTest);
            Console.WriteLine($"Index of {valueToTest}: {index}");

            // 4. Remove a specific element from the array
            array = RemoveElement(array, valueToTest);
            Console.WriteLine($"Array after removing {valueToTest}: " + string.Join(", ", array));

            // 5. Find the maximum and minimum values of the array
            (int max, int min) = FindMaxMin(array);
            Console.WriteLine($"Max value: {max}, Min value: {min}");

            // 6. Reverse the array
            ReverseArray(array);
            Console.WriteLine("Reversed array: " + string.Join(", ", array));

            // 7. Find duplicate values in the array
            var duplicates = FindDuplicates(array);
            Console.WriteLine("Duplicate values: " + string.Join(", ", duplicates));

            // 8. Remove duplicate elements from the array
            array = RemoveDuplicates(array);
            Console.WriteLine("Array without duplicates: " + string.Join(", ", array));
        }

        // 1. Calculate the average value of the array elements
        static double CalculateAverage(int[] arr)
        {
            int sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }

        // 2. Test if the array contains a specific value
        static bool ContainsValue(int[] arr, int value)
        {
            foreach (var num in arr)
            {
                if (num == value)
                    return true;
            }
            return false;
        }

        // 3. Find the index of an array element
        static int FindIndex(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return i;
            }
            return -1;  // Return -1 if the value is not found
        }

        // 4. Remove a specific element from the array
        static int[] RemoveElement(int[] arr, int value)
        {
            List<int> list = new List<int>(arr);
            list.Remove(value);  // Removes the first occurrence of the value
            return list.ToArray();
        }

        // 5. Find the maximum and minimum values of the array
        static (int, int) FindMaxMin(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            foreach (var num in arr)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }
            return (max, min);
        }

        // 6. Reverse the array
        static void ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
        }

        // 7. Find duplicate values in the array
        static List<int> FindDuplicates(int[] arr)
        {
            var seen = new HashSet<int>();
            var duplicates = new List<int>();
            foreach (var num in arr)
            {
                if (seen.Contains(num))
                    duplicates.Add(num);
                else
                    seen.Add(num);
            }
            return duplicates;
        }

        // 8. Remove duplicate elements from the array
        static int[] RemoveDuplicates(int[] arr)
        {
            var seen = new HashSet<int>();
            List<int> result = new List<int>();
            foreach (var num in arr)
            {
                if (!seen.Contains(num))
                {
                    seen.Add(num);
                    result.Add(num);
                }
            }
            return result.ToArray();
        }

    }

}