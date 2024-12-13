
class Program
{

    static void Main(string[] args)
    {
        //4.Создайте массив из 5 чисел, заполните его значениями от пользователя и выведите все элементы массива на экран.
        // Time 26:00



        int[] array = new int[5];


        Console.WriteLine("Введите 5 цифр через пробел");
        
        string? inputNumber = "1 2 3 4 5"; // Console.Readline();
        string[] splitedStrings = inputNumber.Split(' ');


        for (int i = 0; i < splitedStrings.Length; i++)
        {
            array[i] = int.Parse(splitedStrings[i]);
        }


        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

}