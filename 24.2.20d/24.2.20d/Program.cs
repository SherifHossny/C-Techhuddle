using System;

namespace _24._2._20d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2));
        }
    }
}
