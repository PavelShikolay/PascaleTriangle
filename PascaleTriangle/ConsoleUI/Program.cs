using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = 10;

            PascalTriangleGenerator.ShowTriangle(numberOfRows);

            Console.ReadKey();
        }
    }
}
