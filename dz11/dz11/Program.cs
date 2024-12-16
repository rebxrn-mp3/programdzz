using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число n (n <= 20): ");
        int n = int.Parse(Console.ReadLine());

        if (n > 20 || n <= 0)
        {
            Console.WriteLine("n должно быть в диапазоне от 1 до 20.");
            Console.ReadKey();
            return;
        }

        Console.Write("Введите действительное число л (лямбда): ");
        double lambda = double.Parse(Console.ReadLine());

        double[] array = new double[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = Math.Pow(lambda, i) * Math.Exp(-lambda) / Factorial(i);
        }

        PrintArray(array);
        Console.ReadKey();
    }
    static double Factorial(int num)
    {
        if (num == 0) return 1;
        double result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }

    static void PrintArray(double[] array)
    {
        foreach (double item in array)
        {
            Console.Write($"{item:F3} ");
        }
        Console.WriteLine();
    }
}