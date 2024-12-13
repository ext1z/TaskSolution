

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        // Time 00:00 Masalani formulasiga chummadim
        // Fails
        Console.WriteLine("Hello, World!");



        List<double> numbers = new List<double>();
        string input;

        Console.WriteLine("Введите числа (пустая строка для завершения):");
        while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
        {
            if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.");
            }
        }

        Console.WriteLine("Результаты:");
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            double sqrtValue = Math.Sqrt(Math.Abs(numbers[i]));
            Console.WriteLine(sqrtValue.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}