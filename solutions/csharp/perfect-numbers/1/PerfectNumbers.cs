using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1)
            throw new ArgumentOutOfRangeException(nameof(number), "Число має бути додатним");

        int sum = 0;

        for (int i = 1; i * i <= number; i++)
        {
            if (number % i != 0)
                continue;

            sum += i;

            int pair = number / i;
            if (pair != i && pair != number)
                sum += pair;
        }

        // Для 1 цикл додав саме число (i = 1 = number), це не власний дільник
        if (number == 1)
            sum = 0;

        if (sum == number)
            return Classification.Perfect;

        return sum > number ? Classification.Abundant : Classification.Deficient;
    }
}