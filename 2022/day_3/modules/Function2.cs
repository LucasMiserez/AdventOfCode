using System.Text;

public static class Function2
{
    public static int Run(string input)
    {
        string[] rucksack = input.Split(new string[] { Environment.NewLine },
                            StringSplitOptions.RemoveEmptyEntries);
        int score = 0;
        for (int i = 0; i < rucksack.Length + 3; i++)
        {
            if (i % 3 == 0 && i != 0)
            {
                score += Calc(rucksack[i - 3], rucksack[i - 2], rucksack[i - 1]);
            }
        }
        return score;
    }

    private static int Calc(string comp1, string comp2, string comp3) {
        byte[] asciiBytes = Encoding.ASCII.GetBytes(comp3.Intersect(comp2.Intersect(comp1)).ToArray());
        if (asciiBytes[0] < 91) {
            return asciiBytes[0] - 38;
        }
        return asciiBytes[0] - 96;
    }
}