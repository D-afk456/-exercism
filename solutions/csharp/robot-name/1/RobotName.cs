using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly Random random = new Random();
    private static readonly HashSet<string> usedNames = new HashSet<string>();

    private string name;

    public string Name
    {
        get
        {
            if (name == null)
                name = GenerateUniqueName();

            return name;
        }
    }

    public void Reset()
    {
        name = null;
    }

    private static string GenerateUniqueName()
    {
        lock (usedNames)
        {
            string newName;

            do
            {
                char first = (char)('A' + random.Next(26));
                char second = (char)('A' + random.Next(26));
                int number = random.Next(1000);

                newName = $"{first}{second}{number:D3}";
            }
            while (!usedNames.Add(newName));

            return newName;
        }
    }
}
