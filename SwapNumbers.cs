using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, temp = 0;

            Console.WriteLine("Enter First Number :- ");
            first = Convert.ToInt32(Console.ReadLine()); //"10"

            Console.WriteLine("Enter Second Number :- ");
            second = Convert.ToInt32(Console.ReadLine()); //"20"

            Console.WriteLine("Before Swapping :");
            Console.WriteLine("First :- {0} Second :- {1}", first, second);
            temp = first; // temp=10;
            first = second; //first=20;
            second = temp; //second=10;

            Console.WriteLine("After Swapping :");
            Console.WriteLine("First :- {0} Second :- {1}", first, second);
        }
    }
}
