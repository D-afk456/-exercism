using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (string.IsNullOrEmpty(numbers) || sliceLength <= 0 || sliceLength > numbers.Length)
            throw new ArgumentException("Invalid input");

        string[] result = new string[numbers.Length - sliceLength + 1];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = numbers.Substring(i, sliceLength);
        }

        return result;
    }
}