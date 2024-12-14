
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (IsPrime(number))
            {
                Console.WriteLine($"Число {number} является простым.");
            }
            else
            {
                Console.WriteLine($"Число {number} не является простым.");
            }
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректное целое число.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
