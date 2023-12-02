public static class Function2
{
    public static int Run(string input)
    {
        int number = 0;
       
        foreach (string line in input.Split(Environment.NewLine))
        {
            int red, green, blue;
            red = green = blue = 0;
            Char[] delimiters = {';', ','};
            foreach (string round in line.Split(":")[1].Split(delimiters))
            {
                if (round.Contains("red") && red < Convert.ToInt32(round.Split(" ")[1]))
                {
                        red = Convert.ToInt32(round.Split(" ")[1]);
                }
                else if (round.Contains("green") && green < Convert.ToInt32(round.Split(" ")[1]))
                {
                        green = Convert.ToInt32(round.Split(" ")[1]);
                }
                else if (round.Contains("blue") && blue < Convert.ToInt32(round.Split(" ")[1]))
                {
                        blue = Convert.ToInt32(round.Split(" ")[1]);
                }
            }
            number += red * green * blue;
        }

        return number;
    }
}