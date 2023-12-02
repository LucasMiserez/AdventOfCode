public static class Function1
{
    public static int Run(string input)
    {
        int number = 0;
        foreach (string line in input.Split(Environment.NewLine))
        {
            char[] numbers = line.Where(Char.IsDigit).ToArray();
            number += Convert.ToInt32(
                $"{numbers[0]}{numbers[^1]}");  
        }
        return number;
    }
}