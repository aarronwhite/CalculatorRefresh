using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorRefresh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Calculator");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            int a, b;
            Console.WriteLine("Enter a number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine());

            int result = a * b;

            Console.WriteLine("Multiplication is: " + result);
            Console.ReadKey();

            
            
            
        }

        
        
    }
}
