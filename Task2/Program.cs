using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string skaiciusPirmas;
            string skaiciusAntras;
            
            //Enter first number:
            Console.WriteLine("Enter first number");
            //2
            skaiciusPirmas = Console.ReadLine();
            // Enter second number:
            Console.WriteLine("Enter second number");
            // 4
            skaiciusAntras = Console.ReadLine();
            //Calculated sum is: 6
            int result = int.Parse(skaiciusPirmas) + int.Parse(skaiciusAntras);
            Console.WriteLine($"Sum is: {result}");
            // “result” is variable name;
            // $ nurodo, kad skliaustuose gali buti kintamasis - siuo atveju result




            Console.ReadLine();
        }
    }
}
