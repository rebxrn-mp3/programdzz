using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк массива: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов массива: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, cols];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Элемент [{i}, {j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        CalculateEvenSums(array);
        Console.ReadKey();
    }

    static void CalculateEvenSums(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        Console.WriteLine("\nСуммы четных элементов по строкам:");

        for (int i = 0; i < rows; i++) 
        {
            int sum = 0; 
            for (int j = 0; j < cols; j++) 
            {
                if (arr[i, j] % 2 == 0) 
                {
                    sum += arr[i, j]; 
                }
            }
            Console.WriteLine($"Индекс строки {i}: сумма четных элементов = {sum}");
        }
    }
}
