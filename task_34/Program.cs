namespace task_34
{
    internal class Program
    {
        static int[] GetRandomArray(int length, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }
        static void PrintArray(int[] array)
        {
            Console.WriteLine($"[ {string.Join(", ", array)} ]");
        }
        static int GetEventNumber(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) result++;
            }
            return result;
        }
//        Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//        Напишите программу, которая покажет количество чётных чисел в массиве.
//        [345, 897, 568, 234] -> 2
        static void Main(string[] args)
        {
            int[] myArray = GetRandomArray(10, 100, 999);
            PrintArray(myArray);
            int eventNumber = GetEventNumber(myArray);
            Console.WriteLine($"Количество четных чисел в массиве: {eventNumber}");
        }
    }
}