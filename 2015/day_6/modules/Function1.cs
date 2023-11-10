public static class Function1
{
    public static int Run(string input)
    {
        string[] lights = input.Split(new string[] { Environment.NewLine },
                            StringSplitOptions.RemoveEmptyEntries);
        bool[] lightsArray = new bool[1000000];

        foreach (string command in lights)
        {
            string[] parts = command.Split(' ');

            if (parts[1] == "off" || parts[1] == "on")
            {
                int num11 = Convert.ToInt32(parts[2].Split(',')[0]);
                int num12 = Convert.ToInt32(parts[2].Split(',')[1]);
                int num21 = Convert.ToInt32(parts[4].Split(',')[0]);
                int num22 = Convert.ToInt32(parts[4].Split(',')[1]);

                for (int i = num11; i <= num21; i++)
                {
                    for (int j = num12; j <= num22; j++)
                    {
                        int index = i * 1000 + j;
                        lightsArray[index] = parts[1] == "on";
                    }
                }
            }
            else
            {
                int num11 = Convert.ToInt32(parts[1].Split(',')[0]);
                int num12 = Convert.ToInt32(parts[1].Split(',')[1]);
                int num21 = Convert.ToInt32(parts[3].Split(',')[0]);
                int num22 = Convert.ToInt32(parts[3].Split(',')[1]);

                for (int i = num11; i <= num21; i++)
                {
                    for (int j = num12; j <= num22; j++)
                    {
                        int index = i * 1000 + j;
                        lightsArray[index] = !lightsArray[index];
                    }
                }
            }
        }
        return lightsArray.Count(c => c);
    }

}