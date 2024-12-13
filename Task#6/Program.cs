
class Program
{
    static void Main(string[] args)
    {
        // Bubble sort
        // Time 20-minut (Bu masalani avval ishlagan edim, algoritimini eslab olish uchun va yozib chiqish uchun shuncha vaqt ketdi) 


        int[] array = { 5, 4, 3, 2, 1 };

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

        // Result
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}