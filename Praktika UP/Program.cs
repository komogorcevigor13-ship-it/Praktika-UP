using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_UP
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        private double Dev(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
                return 0;
            }
            return (double)a / b;
        }

        public double Divide(int a, int b)
        {
            return Dev(a, b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Сумма: {calc.Add(a, b)}");
            Console.WriteLine($"Частное: {calc.Divide(a, b)}");
        }
    }
}
