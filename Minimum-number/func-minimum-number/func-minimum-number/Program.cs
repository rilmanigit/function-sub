using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_minimum_number


{
    class Program
    {
        static void Main(string[] args)
        {
            string nums;
            int num1, num2;
            Console.WriteLine("Please enter two numbers separated by comma (eg. 2,4): ");
            nums = Console.ReadLine();
            num1 = Convert.ToInt32(nums.Split(',')[0]);
            num2 = Convert.ToInt32(nums.Split(',')[1]);
            int result = Result(num1, num2);
            Console.WriteLine("\nNumber " + result + " is minimum.");
            Console.ReadKey();
        }


        public static int Result(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }

            else
            {
                return num2;
            }

        }



    }
}
