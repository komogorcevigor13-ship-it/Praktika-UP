using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parse — из строки в дату
            string s = "04/03/2024";

            // Американская культура: месяц/день/год
            DateTime us = DateTime.Parse(s, new CultureInfo("en-US"));
            Console.WriteLine($"en-US: {us:dd.MM.yyyy}"); 




            // 2. ParseExact() — строго по шаблону
            DateTime d2 = DateTime.ParseExact("2024-03-15", "yyyy-MM-dd",
                CultureInfo.InvariantCulture);
            Console.WriteLine($"ParseExact: {d2:dd.MM.yyyy}");




            // TryParse() — безопасно, True/False
            bool ok1 = DateTime.TryParse("15.03.2024", out DateTime d3);
            Console.WriteLine($"TryParse: {ok1}");

            // TryParseExact — безопасный разбор по строгому формату
            bool ok2 = DateTime.TryParseExact("15/03/2024", "dd/MM/yyyy",
                                              CultureInfo.InvariantCulture,
                                              DateTimeStyles.None, out DateTime d4);
            Console.WriteLine($"TryParseExact:  {ok2}, {d4}");
        }
    }
   
}
