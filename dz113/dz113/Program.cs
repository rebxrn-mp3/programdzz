using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Исходный массив: " + string.Join(", ", array));

        double result = CalculateSumOfDifferences(array);
        Console.WriteLine($"Сумма модулей разностей: {result}");
        Console.ReadKey();
    }

    static double CalculateSumOfDifferences(int[] arr)
    {
        double sum = 0;

        for (int i = 1; i < arr.Length - 1; i++)
        {
            sum += Math.Abs(arr[i - 1] - arr[i + 1]);
        }

        return sum;
    }
}
