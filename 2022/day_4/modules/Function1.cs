public static class Function1
{
    public static int Run(string input)
    {
        string[] rucksack = input.Split(new string[] { Environment.NewLine },
                            StringSplitOptions.RemoveEmptyEntries);
        int score = 0;
        
        foreach (string pair in rucksack)
        {
            score += Calc(pair.Split(",")[0], pair.Split(",")[1]);
        }
        return score;
    }

    private static int Calc(string pair1, string pair2) {
        IEnumerable<int> pair1List = Enumerable.Range(Convert.ToInt32(pair1.Split("-")[0]), Convert.ToInt32(pair1.Split("-")[1]) - Convert.ToInt32(pair1.Split("-")[0]) + 1);
        IEnumerable<int> pair2List = Enumerable.Range(Convert.ToInt32(pair2.Split("-")[0]), Convert.ToInt32(pair2.Split("-")[1]) - Convert.ToInt32(pair2.Split("-")[0]) + 1);
        if (!pair2List.ToArray().Except(pair1List.Intersect(pair2List)).Any() || !pair1List.ToArray().Except(pair1List.Intersect(pair2List)).Any())
        {
            return 1;
        }
        return 0;
    }
}