// 5minut

using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //5.Напишите программу, которая находит минимальное и максимальное значение в массиве из 10 чисел,
        //    введенных пользователем.

        // Time 33 minut


        Console.WriteLine("Введите цифры с пробелом:");
        string input = Console.ReadLine()!;

        string[] splitedStrings = input.Split(' ');

        int[] parsedArray = ParsedArray(splitedStrings);

        SortedArray(ref parsedArray);
        OutputResult(parsedArray);

        static int[] ParsedArray(string[] strings)
        {
            int[] array = new int[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                array[i] = int.Parse(strings[i]);
            }

            return array;
        }

        static void SortedArray(ref int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        static void OutputResult(params int[] array)
        {
            int[] outputArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                outputArray[i] = array[i];
            }

            Console.WriteLine($"Min : {outputArray[0]}\nMax : {outputArray[^1]}");
        }
    }
}