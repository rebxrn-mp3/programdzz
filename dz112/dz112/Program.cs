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

        ModifyArray(array);

        Console.WriteLine("Измененный массив: " + string.Join(", ", array));
        Console.ReadKey();
    }

    static void ModifyArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j <= i; j++)
            {
                sum += arr[j];
            }
            arr[i] = sum;
        }
    }
}
