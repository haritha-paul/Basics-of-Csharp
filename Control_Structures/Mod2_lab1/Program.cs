using System;

namespace Mod2_lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Trying out if condition
            Console.WriteLine("Please enter a value:");

            int input = Int32.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Even number...!!");
            }
            else
            {
                Console.WriteLine("Odd number..!!");
            }

            //Trying out loops

            int n = input;
            while(n > 0)
            {
                Console.WriteLine($"Current value of n is {n}");
                n--;
            }
;        }
    }
}
