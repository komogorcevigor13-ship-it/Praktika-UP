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
            string s1 = "hello";
            string s2 = "world";
            string s3 = "hello";

            // Compare()
            int result = string.Compare(s1, s2);
            Console.WriteLine($"Compare(s1, s2) = {result}"); 

            // Equals()
            Console.WriteLine($"s1.Equals(s3) = {s1.Equals(s3)}"); 
            Console.WriteLine($"s1.Equals(s2) = {s1.Equals(s2)}"); 

            // CompareOrdinal()
            int ord = string.CompareOrdinal(s1, s2);
            Console.WriteLine($"CompareOrdinal(s1, s2) = {ord}"); 

            // IndexOf()
            Console.WriteLine($"s1.IndexOf('l') = {s1.IndexOf('l')}"); 

            // Contains()
            Console.WriteLine($"s2.Contains(\"or\") = {s2.Contains("or")}"); 

            // Операторы == и !=
            Console.WriteLine($"s1 == s3: {s1 == s3}"); 
            Console.WriteLine($"s1 != s2: {s1 != s2}"); 
        }
    }
}
