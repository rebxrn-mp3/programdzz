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
            //1zad
            Console.Write("Введите натуральное число n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите действительное число x: ");
            double x = double.Parse(Console.ReadLine());

            double sum = 0.0;
            for (int i = 0; i <= n; i++)
            {
                double term = (double)(i + 1) / (i + 2) * Math.Pow(x, i);
                sum += term;
            }

            Console.WriteLine($"Сумма равна: {sum}");
            Console.ReadKey();
        }
    }

}
