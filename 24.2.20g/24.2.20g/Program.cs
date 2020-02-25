using System;

namespace _24._2._20g
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x= ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("y= ");
            var y = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(x, y));
        }
    }
}
