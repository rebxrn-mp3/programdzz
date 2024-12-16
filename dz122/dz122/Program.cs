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

        if (!CheckColumnsAscending(array))
        {
            Console.WriteLine("Элементы столбцов не идут в порядке возрастания.");
        }
        else
        {
            Console.WriteLine("Элементы всех столбцов упорядочены по возрастанию.");
        }
        Console.ReadKey();
    }

    static bool CheckColumnsAscending(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        for (int j = 0; j < cols; j++) 
        {
            for (int i = 1; i < rows; i++) 
            {
                if (arr[i, j] < arr[i - 1, j]) 
                {
                    Console.WriteLine($"Нарушение порядка в столбце {j}: элементы [{i - 1}, {j}] и [{i}, {j}]");
                    return false; 
                }
            }
        }

        return true; 
    }
}
