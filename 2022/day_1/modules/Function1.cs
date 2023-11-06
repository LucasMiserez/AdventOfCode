public static class Function1
{
    public static int Run(string input)
    {
        string[] elves = input.Split(new string[] { Environment.NewLine + Environment.NewLine },
                               StringSplitOptions.RemoveEmptyEntries);
        int cal = 0;

        for (int i = 0; i < elves.Length; i++)
        {
            string[] elvestemp = elves[i].Split(new string[] { Environment.NewLine },
                               StringSplitOptions.RemoveEmptyEntries);
            int caltemp = 0;
            foreach (string item in elvestemp)
            {
                caltemp += Convert.ToInt32(item);
            }
            if (caltemp > cal)
            {
                cal = caltemp;
            }
        }

        return cal;
    }
}