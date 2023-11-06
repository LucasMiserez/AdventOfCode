public static class Function2
{
    public static int Run(string input)
    {
        string[] elves = input.Split(new string[] { Environment.NewLine + Environment.NewLine },
                               StringSplitOptions.RemoveEmptyEntries);
        List<int> cal = new List<int>() { 0, 0, 0 };

        for (int i = 0; i < elves.Length; i++)
        {
            string[] elvestemp = elves[i].Split(new string[] { Environment.NewLine },
                               StringSplitOptions.RemoveEmptyEntries);
            int caltemp = 0;
            foreach (string item in elvestemp)
            {
                caltemp += Convert.ToInt32(item);
            }
            if (caltemp > cal[0] || caltemp > cal[1] || caltemp > cal[2])
            {
                cal[cal.IndexOf(cal.Min())] = caltemp;
            }
        }

        return cal.Sum();
    }
}