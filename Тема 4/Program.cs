using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int result = a / b;

                Console.WriteLine("Результат деления: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка: делить на ноль нельзя!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка: необходимо вводить числа!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Программа завершена.");
            }
        }
    }
}
