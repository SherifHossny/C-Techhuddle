using System;

namespace _24._2._20c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1: ");
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Number 2: ");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum is: " + getNumSum(num1, num2));
            Console.WriteLine("The difference is: " + getNumDifference(num1, num2));
            Console.WriteLine("The total is: " + (getNumSum(num1, num2) + getNumDifference(num1, num2)));   
        }

        public static int getNumSum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int getNumDifference(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
