using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

        int thirdDigit = GetThirdDigit(number);

        if (thirdDigit != -1)
        {
            Console.WriteLine($"Третья цифра: {thirdDigit}");
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }

    static int GetThirdDigit(int number)
    {
        int count = CountDigits(number);

        if (count < 3)
        {
            return -1; // Третьей цифры нет
        }

        int thirdDigit = 0;
        for (int i = 0; i < count - 3; i++)
        {
            number /= 10;
        }
        thirdDigit = number % 10;

        return thirdDigit;
    }

    static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }
}

