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
            Console.WriteLine("Please enter an operator");
            Console.WriteLine("[+] [-] [*] [/]");
            string userValue = Console.ReadLine();
            int a, b;
            
            Console.WriteLine("Enter a number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine());

            int answer = 0;

            if (userValue == "+")
                answer = a + b;

            else if (userValue == "-")
                answer = a - b;

            else if (userValue == "*")
                answer = a * b;

            else if (userValue == "/")
                answer = a / b;
            
            
          
            Console.WriteLine("The answer is: " + answer);
            Console.ReadLine();
            
        }
    }
}






            

