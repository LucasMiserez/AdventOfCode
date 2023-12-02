public static class Function1
{
    public static int Run(string input)
    {
        int red, green, blue, number;
        red = green = blue = number = 0;
        foreach (string line in input.Split(Environment.NewLine))
        {
            string[] split1 = line.Split(":");
            bool succes = true;
            Char[] delimiters = {';', ','};
            foreach (string round in split1[1].Split(delimiters))
            {
                    int numberOfBalls = Convert.ToInt32(round.Split(" ")[1]);
                    succes = ((round.Contains("red") && numberOfBalls <= red) || (round.Contains("green") && numberOfBalls <= green) || (round.Contains("blue") && numberOfBalls <= blue));
                    if (!succes)
                    {
                        break;
                    }
            }
            if (succes)
            {
                number += Convert.ToInt32(split1[0].Split(" ")[1]);
            }
        }

        return number;
    }
}