using System;
using System.Linq;
using System.Collections.Generic;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array size: ");
            string temp = Console.ReadLine();
            int array_size = int.Parse(temp);

            if (array_size >= 2)
            {
                // array initialization
                List<int> arr = new List<int>();
                for (int i = 0; i < array_size; i++)
                {
                    string a = Console.ReadLine();
                    int b = int.Parse(a);
                    arr.Add(b);
                }
                Console.Write("The original array: [");
                for (int i = 0; i < array_size; i++)
                {
                    if (i + 1 != array_size)
                    {
                        Console.Write(arr[i] + ", ");
                    }
                    else
                    {
                        Console.Write(arr[i] + "].");
                    }
                }

                //finding the index and the value of the minimum element in the array
                int min_index = 0;
                int min_value = 2147483647;
                for (int i = 0; i < array_size; i++)
                {
                    if (min_value > arr[i])
                    {
                        min_value = arr[i];
                    }
                }

                for (int i = 0; i < array_size; i++)
                {
                    if (arr[i] == min_value)
                    {
                        min_index = i;
                        break;
                    }
                }
                //Console.WriteLine("min value: " + min_value + ", index: " + min_index);

                //finding the index and the value of the maximum element in the array
                int max_index = 0;
                int max_value = -2147483647;
                for (int i = 0; i < array_size; i++)
                {
                    if (max_value < arr[i])
                    {
                        max_value = arr[i];
                    }
                }

                for (int i = array_size - 1; i >= 0; --i)
                {
                    if (arr[i] == max_value)
                    {
                        max_index = i;
                        break;
                    }
                }
                //Console.WriteLine("max value: " + max_value + ", index: " + max_index);

                Console.Write(" The sum of the required elements: ");
                int result = 0;
                if (max_index > min_index)
                {
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
                else
                {
                    for (int i = max_index; i <= min_index; i++)
                    {
                        if (i == min_index)
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
            }
            else
            {
                Console.WriteLine("You should enter at least 2");
            }
        }
    }
}
