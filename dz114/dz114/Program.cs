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

        Console.Write("Введите число л (лямбда): ");
        double lambda = double.Parse(Console.ReadLine());

        double[] differences = CalculateDifferences(array, lambda);

        Console.WriteLine("Массив разностей:");
        Console.WriteLine(string.Join(", ", differences));
        Console.ReadKey();
    }

    static double[] CalculateDifferences(int[] arr, double a)
    {
        double[] differences = new double[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            differences[i] = arr[i] - a;
        }

        return differences;
    }
}
