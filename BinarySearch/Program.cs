using System;

namespace MyBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            int[] marks = { 45, 55, 65, 75, 79, 85, 88, 90, 95, 100 };

            Console.Write("Enter the value to search: ");
            if (int.TryParse(Console.ReadLine(), out int Value))
            {
                int index = BinarySearch(marks, Value);

                if (index != -1)
                {
                    Console.WriteLine($"Element {Value} found at index {index}");
                }
                else
                {
                    Console.WriteLine($"Element {Value} not found in the array");
                }
            }
        }

        static int BinarySearch(int[] arr, int searchEle)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == searchEle)
                {
                    return mid; // Element found, return its index
                }

                if (arr[mid] < searchEle)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // Element not found
        }
    }

}