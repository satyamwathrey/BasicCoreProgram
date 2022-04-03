using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int Rem;

            Console.WriteLine("Enter number to check whether it is even or odd");
            Num = Convert.ToInt32(Console.ReadLine());
            Rem = Num % 2;
            
            if(Rem==0)
            {
                Console.WriteLine("{0} is an Even number", Num);
            }
            else
            {
                Console.WriteLine("{0} is an Odd number", Num);
            }
        }
    }
}
