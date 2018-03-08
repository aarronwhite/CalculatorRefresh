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
            Console.WriteLine("Please enter an Operator");
            Console.WriteLine("[+] [-] [*] [/]");
            string Operator = Console.ReadLine();

            Console.Write("How many numbers do you want to " + Operator + "? ");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter a number" + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int answer = numbers [0];

            for (int i = 1; i < count; i++)

                if (Operator == "+")
                    answer = answer + numbers[i];

                else if (Operator == "-")
                    answer = answer - numbers[i];

                else if (Operator == "*")
                    answer = answer * numbers[i];

                else if (Operator == "/")
                    answer = answer / numbers[i];
            
            
          
            Console.WriteLine("The answer is: " + answer);
            Console.ReadLine();
            
        }
    }
}






            

