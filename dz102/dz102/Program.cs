using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zad2
            Console.Write("Введите натуральное число n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Число n должно быть натуральным (положительным).");
                return;
            }

            double product = 1.0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Введите число a{i}: ");
                double a = double.Parse(Console.ReadLine());
                product *= a;
            }

            Console.WriteLine($"Произведение введенных чисел равно: {product}");
            Console.ReadKey();
        }
    }

}