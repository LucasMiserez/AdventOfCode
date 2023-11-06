public static class Function1
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

    private static int Calc(int[] roundInt) {
        if (roundInt[0] == roundInt[1]) {
            return roundInt[1] + 3;
        }
        if (roundInt[0] == 3 && roundInt[1] == 1 || roundInt[0] == 1 && roundInt[1] == 2 || roundInt[0] == 2 && roundInt[1] == 3)
        {
            return roundInt[1] + 6;
        }
        return roundInt[1];
    }
}