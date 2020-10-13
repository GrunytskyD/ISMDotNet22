using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Значення x");
            double numberx = double.Parse(Console.ReadLine());
            Console.WriteLine("Значення a");
            double numbera = double.Parse(Console.ReadLine());
            Console.WriteLine("Значення b");
            double numberb = double.Parse(Console.ReadLine());
            double y=numberx*numbera/numberb;
            Console.WriteLine($"у={y}");
        }
    }
}
