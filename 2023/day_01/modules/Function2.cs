public static class Function2
{
    public static int Run(string input)
    {
        int number = 0;
        foreach (string line in input.Split(Environment.NewLine))
        {
            char[] numbers = line.Replace("one", "o1e").Replace("two", "t2o").Replace("three", "thr3e").Replace("four", "fo4ur").Replace("five", "fi5e").Replace("six", "s6x").Replace("seven", "se7en").Replace("eight", "eig8t").Replace("nine", "ni9e").Where(Char.IsDigit).ToArray();
            number += Convert.ToInt32(
                $"{numbers[0]}{numbers[^1]}");
        }
        return number;
    }
}