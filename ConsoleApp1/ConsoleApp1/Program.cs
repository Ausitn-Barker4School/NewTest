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
            int Product;
            int Difference;
            int Quotient;
            Console.WriteLine("Enter First Interger: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Interger: ");
           number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;
            Product = number1 * number2;
            Difference = number1 - number2;
            Quotient = number1 / number2;

            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Product is {Product}");
            Console.WriteLine($"Difference is {Difference}");
            Console.WriteLine($"Quotient is {Quotient}");

        }
    }
}
