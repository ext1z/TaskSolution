// Time 25:00
// Fail


class Program
{
    static bool IsPalindrome(int number)
    {
        string original = number.ToString();
        string reversed = new string(original.Reverse().ToArray());
        return original == reversed;
    }

    static void Main()
    {
        Console.Write("Введите число: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (IsPalindrome(number))
            {
                Console.WriteLine($"Число {number} является палиндромом.");
            }
            else
            {
                Console.WriteLine($"Число {number} не является палиндромом.");
            }
        }
        else
        {
            Console.WriteLine("Введите допустимое целое число.");
        }
    }
}
