using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 m = new Class1();

            m.Hello();
            m.Bye();

            Console.WriteLine(m.Add(3, 5));   
            Console.WriteLine(m.Half(10));     
            Console.WriteLine(m.Name());       
        }
    }
}
