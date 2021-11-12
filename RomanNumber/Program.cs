using System;

namespace RomanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm to convert decimal into Roman numbers.");

            Console.WriteLine();
            Console.WriteLine("------||PROGRAM||------");
            ConvertNumber();
        }
        static void ConvertNumber()
        {
            Console.Write("Write a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write($"The number in Roman: {Roman.ToRoman(num)}");
            Console.ReadKey();
        }
    }
}
