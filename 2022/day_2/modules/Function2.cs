public static class Function2
{
    public static int Run(string input)
    {
        string[] rounds = input.Split(new string[] { Environment.NewLine },
                               StringSplitOptions.RemoveEmptyEntries);

        int score = 0;
        foreach (string round in rounds)
        {
            score += CheckScore(round.Split(" "));
        }

        return score;
    }

    private static int CheckScore(string[] round)
    {
        int[] roundInt = { 0, 0 };

        for (int i = 0; i < round.Length; i++)
        {
            if (round[i] == "A" || round[i] == "X")
            {
                roundInt[i] = 1;
            }
            if (round[i] == "B" || round[i] == "Y")
            {
                roundInt[i] = 2;
            }
            if (round[i] == "C" || round[i] == "Z")
            {
                roundInt[i] = 3;
            }
        }
        return Calc(roundInt);
    }

    private static int Calc(int[] roundInt)
    {
        if (roundInt[1] == 2)
        {
            return roundInt[0] + 3;
        }
        if (roundInt[1] == 1)
        {
            switch (roundInt[0])
            {
                case 1:
                    return 3;
                case 2:
                    return 1;
                default:
                    return 2;
            }
        }
        switch (roundInt[0])
        {
            case 1:
                return 2 + 6;
            case 2:
                return 3 + 6;
            default:
                return 1 + 6;
        }
    }
}