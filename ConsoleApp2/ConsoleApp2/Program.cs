using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //R is radious
            Console.WriteLine("Enter Radius");
            double R = Convert.ToDouble(Console.ReadLine());
            double Diameter = 2 * R;
            double Circumference = 2 * Math.PI * R;
            double Area = Math.PI * R * R;
            Console.WriteLine("The Diameter is " + Diameter);
            Console.WriteLine("The Circumference is " + Circumference);
            Console.WriteLine("The Area is " + Area); 
        }
    }
}
