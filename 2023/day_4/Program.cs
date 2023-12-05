// Challenge link: https://adventofcode.com/2023/day/4
using System;
using System.IO;

namespace day_4;

class Program
{
    const string INPUTPATH = "modules/input.txt";
    static void Main(string[] args)
    {
        try
        {
            string input = File.ReadAllText(INPUTPATH).Trim();
            Console.WriteLine($"Functie 1: {Function1.Run(input)}");
            Console.WriteLine($"Functie 2: {Function2.Run(input)}");
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred while reading the file: " + e.Message);
        }
    }
}
