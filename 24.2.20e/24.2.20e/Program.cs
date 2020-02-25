using System;

namespace _24._2._20e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radius: ");
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.PI * Math.Pow(r, 2));
        }
    }
}
