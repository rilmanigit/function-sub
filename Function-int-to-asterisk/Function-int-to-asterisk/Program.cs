using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_int_to_asterisk
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program asks a number (an integer) and will print given number of asterisks on a screen
            //Negative numbers are not allowed and zero will result an announcement of entered zero
            int i;
            int n;
            Console.Write("Please enter a number (an integer): ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Negative number {0} is not allowed number.", n);
            }

            else if (n == 0)
            {
                Console.WriteLine("You have given {0}, no asterisks printed.", n);
            }

            for (i = 1; i <= n; ++i)
            {
                Console.Write("*");
            }
            Console.ReadKey();
            
        }
    }
}
