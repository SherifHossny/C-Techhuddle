using System;

namespace _24._2._20f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            var a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
