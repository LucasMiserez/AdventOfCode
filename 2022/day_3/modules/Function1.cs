using System.Text;

public static class Function1
{
    public static int Run(string input)
    {
        string[] rucksack = input.Split(new string[] { Environment.NewLine },
                            StringSplitOptions.RemoveEmptyEntries);
        int score = 0;
        
        foreach (string comp in rucksack)
        {
            score += Calc(comp[..(comp.Length / 2)], comp[(comp.Length / 2)..]);
        }
        return score;
    }

    private static int Calc(string comp1, string comp2) {
        byte[] asciiBytes = Encoding.ASCII.GetBytes(comp1.Intersect(comp2).ToArray());
        if (asciiBytes[0] < 91) {
            return asciiBytes[0] - 38;
        }
        return asciiBytes[0] - 96;
    }
}