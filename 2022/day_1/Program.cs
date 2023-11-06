// Challenge link: https://adventofcode.com/2022/day/1
using System;
using System.IO;

namespace day_1;

class Program
{
    const string INPUTPATH = "modules/input.txt";
    static void Main(string[] args)
    {
        try
        {
            string input = File.ReadAllText(INPUTPATH);
            Console.WriteLine($"Functie 1: {Function1.Run(input)}");
            Console.WriteLine($"Functie 2: {Function2.Run(input)}");
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred while reading the file: " + e.Message);
        }
    }
}
