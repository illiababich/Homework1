using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the first 9 digits of the ISBN code: ");
            string input_string = Console.ReadLine();
            int sum = 0;
            for (int i = 0, j = 10; i < 9; i++, j--)
            {
                sum += j * (int)Char.GetNumericValue(input_string[i]);
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum % 11);
            int d10 = 11 - (sum % 11);
            string ISBN;
            if (d10 == 10)
            {
                ISBN = input_string + "X";
            }
            else
            {
                ISBN = input_string + d10;
            }
            Console.WriteLine(d10);
            Console.WriteLine("ISBN: " + ISBN);
        }
    }
}
