using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;
            Console.WriteLine("Enter First Interger: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Interger: ");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine($"Sum is {sum}");
        }
    }
}
