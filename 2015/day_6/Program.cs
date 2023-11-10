// Challenge link: https://adventofcode.com/2015/day/6
using System;
using System.Diagnostics;
using System.IO;

namespace day_6;

class Program
{
    const string INPUTPATH = "modules/input.txt";
    static void Main(string[] args)
    {
        try
        {
            string input = File.ReadAllText(INPUTPATH).Trim();
            Stopwatch stopwatch = Stopwatch.StartNew(); 
            string f1 = $"Functie 1: {Function1.Run(input)}";
            stopwatch.Stop();
            Console.WriteLine($"{f1} (in {stopwatch.ElapsedMilliseconds} miliseconden)");
            Console.WriteLine($"Functie 2: {Function2.Run(input)}");
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred while reading the file: " + e.Message);
        }
    }
}
