using System;

namespace _24._2._20b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Age: ");
            var age = Console.ReadLine();

            Console.Write("University: ");
            var uni = Console.ReadLine();

            getOutput(name, age, uni); 
        }
        public static void getOutput(string name, string age, string uni)
        {
            Console.WriteLine($"Name:{name.Split(" ")[0]} {name.Split(" ")[1]}, Age: {age}" + Environment.NewLine + $"University: {uni}");
        }
    }
}
