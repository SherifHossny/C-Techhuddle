using System;

namespace _24._2._20a
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("City: ");
            var city = Console.ReadLine();

            Console.Write("Street: ");
            var street = Console.ReadLine();

            Console.Write("House Number: ");
            var strN = Console.ReadLine();

            var output = getOutput(name, city, street, strN);
            Console.WriteLine(output);


        }

        public static string getOutput(string name, string city, string street, string strN)
        {
            return $"Name:{name.Split(" ")[0]} {name.Split(" ")[1]}, Address: {city}, {street} {strN}";
        }
    }
}
