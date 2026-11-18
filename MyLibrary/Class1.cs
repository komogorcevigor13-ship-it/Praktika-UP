using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyLibrary
{
    public class Class1
    {
        // 2 метода void
        public void Hello()
        {
            System.Console.WriteLine("Привет!");
        }

        public void Bye()
        {
            System.Console.WriteLine("Пока!");
        }

        // 3 метода с возвращаемыми значениями
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Half(int a)
        {
            return a / 2.0;
        }

        public string Name()
        {
            return "Иван";
        }
    }
}
