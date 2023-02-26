namespace task_38
{
    internal class Program
    {
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
        static double [] GetRandomArray(int length, int minValue, int maxValue)
        {
            Random random = new Random();
            double[] array = new double[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = minValue + random.NextDouble() * (maxValue - minValue);
            }
            return array;
        }
        static void PrintArray(double[] array)
        {
            Console.WriteLine($"[ {string.Join(", ", array)} ]");
        }
        static (double, double)GetMaxMinElement(double[] array)
        {
            double maxElement = array[0];
            double minElement = array[1];
            for (int i = 0; i < array.Length; i ++)
            {
                if (array[i] > maxElement)maxElement = array[i];                
                else if (array[i] < minElement) minElement = array[i];
            }
            return (minElement, maxElement);
        }


        //Задача 38: Задайте массив вещественных чисел.
        //Найдите разницу между максимальным и минимальным элементов массива.
        //[3 7 22 2 78] -> 76
        static void Main(string[] args)
        {
            int length = GetConvertUserMassedge($"Введите длинну массива: ");
            int leftBoard = GetConvertUserMassedge($"Введите минимальную границу массива: ");
            int rightBoard = GetConvertUserMassedge($"Введите максимальную границу массива: ");
            double[] myArray = GetRandomArray(length, leftBoard, rightBoard);
            (double min,  double max) = GetMaxMinElement(myArray);
            
            double diff = max - min;

            PrintArray(myArray);
            Console.WriteLine($"max = {max}, min = {min}");
            Console.WriteLine($"Разница между максимумом и минимумом: {diff:f2}");

        }
    }
}