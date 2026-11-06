using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var counts = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach (char nucleotide in sequence)
        {
            if (!counts.ContainsKey(nucleotide))
                throw new ArgumentException("Недопустимий нуклеотид");

            counts[nucleotide]++;
        }

        return counts;
    }
}