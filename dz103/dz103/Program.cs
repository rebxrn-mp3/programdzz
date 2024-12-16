using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zad3
            Console.Write("Введите значение a (1 < a < 1.5): ");
            double a = double.Parse(Console.ReadLine());

            if (a <= 1 || a >= 1.5)
            {
                Console.WriteLine("Ошибка: значение a должно быть в диапазоне (1, 1.5).");
                return;
            }


            Console.WriteLine($"Значения n, при которых все числа последовательности не меньше {a}:");

            for (int n = 2; ; n++)
            {
                double term = 1 + (1.0 / n);

                if (term < a)
                {
                    break;
                }

                Console.WriteLine(n);
                Console.ReadKey();
            }
        }
    }
}