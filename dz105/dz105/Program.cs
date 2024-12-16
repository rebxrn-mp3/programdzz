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
            // zad5
            Console.Write("Введите первое натуральное число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе натуральное число: ");
            int b = int.Parse(Console.ReadLine());

            int nod = EuclideanAlgorithm(a, b);

            Console.WriteLine($"Наибольший общий делитель чисел {a} и {b} равен {nod}.");
            Console.ReadKey();
        }

        static int EuclideanAlgorithm(int x, int y)
        {
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            return x;
        }

    }
}