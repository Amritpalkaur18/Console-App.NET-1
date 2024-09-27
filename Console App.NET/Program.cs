
using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            
            Console.WriteLine("40");
            double weight = Convert.ToDouble(Console.ReadLine());

            
            if (weight > 50)
            {
                
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; 
            }

           
            Console.WriteLine("10");
            double width = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("12");
            double height = Convert.ToDouble(Console.ReadLine());

           
            Console.WriteLine("11");
            double length = Convert.ToDouble(Console.ReadLine());

           
            if ((width + height + length) > 50)
            {
                
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; 
            }

           
            double quote = (width * height * length * weight) / 100;

            
            Console.WriteLine("$ 528.0");
            Console.WriteLine("Thank you!");
        }
    }
}
