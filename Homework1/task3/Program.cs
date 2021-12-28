using System;
using System.Linq;
using System.Collections.Generic;

namespace HW1
{
    class Program
    {
        static void Logic(int min_index, int max_index, int[] arr)
        {
            int result = 0;
            for (int i = min_index; i <= max_index; i++)
            {
                if (i == max_index)
                {
                    Console.Write(arr[i] + " = ");
                    result += arr[i];
                }
                else
                {
                    Console.Write(arr[i] + " + ");
                    result += arr[i];
                }
            }
            Console.WriteLine(result + ".");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the array size: ");
            string temp = Console.ReadLine();
            int array_size = int.Parse(temp);

            if (array_size >= 2)
            {
                // array initialization
                int[] arr = new int[array_size];
                for (int i = 0; i < array_size; i++)
                {
                    string a = Console.ReadLine();
                    int b = int.Parse(a);
                    arr[i] = b;
                }

                // original array output
                Console.Write("The original array: ");
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }

                int arr_min = Array.FindIndex(arr, i => i == arr.Min()); //finding the index and the value of the minimum element in the array
                int arr_max = Array.FindLastIndex(arr, i => i == arr.Max()); //finding the index and the value of the maximum element in the array

                Console.WriteLine(" The sum of the required elements: ");

                if (arr_max > arr_min)
                {
                    Logic(arr_min, arr_max, arr);
                }
                else
                {
                    Logic(arr_max, arr_min, arr);
                }
            }
            else
            {
                Console.WriteLine("You should enter at least 2");
            }
        }
    }
}
