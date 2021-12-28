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

                List<int> twotwos = number_converted_to_ternary.FindAll(i => i == 2);
                
                if (twotwos.Count == 2)
                {
                    Console.Write(i + " ");
                }
                number_converted_to_ternary.Clear();
            }
        }
    }
}
