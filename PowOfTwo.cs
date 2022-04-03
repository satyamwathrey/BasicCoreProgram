using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;


            Console.Write("Enter a number:");//input from User
            num = Convert.ToInt32(Console.ReadLine());
            int result = num * num; //num*2 if 2*2==4
            Console.WriteLine(result);//Op
            Console.ReadLine();
        }
    }
}
