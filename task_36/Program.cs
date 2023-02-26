using System.Reflection.Metadata.Ecma335;

namespace task_36
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
        static int GetSumUnfairPosition(int[] array)
        {
            int result = 0;
            for (int i = 1; i < array.Length; i +=2)
            {
                result += array[i];
            }
            return result;
        }

        static int GetConvertUserMassedge(string userMassedge)
        {
            int result = 0;
            while (true)
            {
                Console.Write(userMassedge);
                bool convert = int.TryParse(Console.ReadLine(), out result);
                if (convert) return result;
                else Console.WriteLine($"Ошибка! Введенная информация не корректна. Попробуйте еще раз.");
            }
        }
        
//        Задача 36: Задайте одномерный массив, заполненный случайными числами.
//        Найдите сумму элементов, стоящих на нечётных позициях.
//        [3, 7, 23, 12] -> 19
//        [-4, -6, 89, 6] -> 0
        static void Main(string[] args)
        {
            int length = GetConvertUserMassedge($"Введите длинну массива: ");
            int leftBoard = GetConvertUserMassedge($"Введите минимальную границу массива: ");
            int rightBoard = GetConvertUserMassedge($"Введите максимальную границу массив: ");
            int[] myArray = GetRandomArray(length, leftBoard, rightBoard);
            Console.WriteLine($"[ {string.Join(", ", myArray)} ]");
            int sum = GetSumUnfairPosition(myArray);
            Console.WriteLine($"Сумма элементов массива на нечетных позициях: {sum}");
        }
    }
}