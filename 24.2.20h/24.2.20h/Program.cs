using System;

namespace _24._2._20h
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Height= ");
            var h = double.Parse(Console.ReadLine());
            Console.Write("Side= ");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of the triangle= " + h * (b / 2));
        }
    }
}
