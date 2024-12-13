

class Program
{
    static void Main(string[] args)
    {
        // Time 09:31

        Console.Write("Введите число:  ");
        var input = Console.ReadLine();

        int num = int.Parse(input!);


        Console.WriteLine(DividedYourself(num));

        bool DividedYourself(int number)
        {
            if (number / 1 == number)
            {
                return true;
            }
            return false;
        }
    }
}
