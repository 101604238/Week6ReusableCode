using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedMath4238;

namespace DLLTest4238
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer");
            var input = int.Parse(Console.ReadLine());

            var calculator = new Calculator();

            var result = calculator.Factorial(input);

            Console.WriteLine("The Factorial of " + input.ToString() + " is " + result.ToString());
            Console.ReadKey();
        }
    }
}