using System;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        const string allowedSymbols = " .-()+";

        // Букви та інші зайві символи недопустимі
        foreach (char c in phoneNumber)
        {
            bool isDigit = c >= '0' && c <= '9';
            if (!isDigit && !allowedSymbols.Contains(c))
                throw new ArgumentException("Недопустимий символ у номері");
        }

        // Залишаємо тільки цифри
        string digits = new string(phoneNumber.Where(c => c >= '0' && c <= '9').ToArray());

        // Прибираємо код країни, якщо він є
        if (digits.Length == 11)
        {
            if (digits[0] != '1')
                throw new ArgumentException("Код країни має бути 1");
            digits = digits.Substring(1);
        }

        if (digits.Length != 10)
            throw new ArgumentException("Номер має містити 10 цифр");

        // Код зони й код станції мають починатися з цифри від 2 до 9
        if (digits[0] == '0' || digits[0] == '1')
            throw new ArgumentException("Код зони не може починатися з 0 або 1");

        if (digits[3] == '0' || digits[3] == '1')
            throw new ArgumentException("Код станції не може починатися з 0 або 1");

        return digits;
    }
}