using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "cat";
            string s2 = "dog";
            string s3 = "cat";

            // Compare()
            int result = string.Compare(s1, s2);
            Console.WriteLine($"Compare(s1, s2) = {result}"); //лексическое сравнение

            // Equals()
            Console.WriteLine($"s1.Equals(s3) = {s1.Equals(s3)}"); //проверка на равенство
            Console.WriteLine($"s1.Equals(s2) = {s1.Equals(s2)}"); 

            // CompareOrdinal()
            int ord = string.CompareOrdinal(s1, s2);
            Console.WriteLine($"CompareOrdinal(s1, s2) = {ord}"); //побайтовое

            // IndexOf()
            Console.WriteLine($"s1.IndexOf('a') = {s1.IndexOf('a')}"); //поиск символа

            // Contains()
            Console.WriteLine($"s2.Contains(\"og\") = {s2.Contains("og")}"); //содержит ли строку

            // Операторы == и !=
            Console.WriteLine($"s1 == s3: {s1 == s3}"); 
            Console.WriteLine($"s1 != s2: {s1 != s2}"); 
        }
    }
}
