using System;
using System.Collections.Generic;

namespace two2s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two integers: ");
            int first_integer = int.Parse(Console.ReadLine());
            int second_integer = int.Parse(Console.ReadLine());
            List<int> number_converted_to_ternary = new List<int> { };
            for (int i = first_integer; i <= second_integer; i++)
            {
                int temp = i;
                while (temp > 0)
                {
                    number_converted_to_ternary.Add(temp % 3);
                    temp /= 3;
                }
                int counter = 0;
                for (int j = 0; j < number_converted_to_ternary.Count; j++)
                {
                    if (number_converted_to_ternary[j] == 2)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    Console.Write(i + " ");
                }
                number_converted_to_ternary.Clear();
            }
        }
    }
}
