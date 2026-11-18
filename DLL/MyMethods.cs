namespace DLL
{
    public class MyMethods
    {
        // ===== 2 метода void =====
        public void SayHello(string name)
        {
            Console.WriteLine($"Привет, {name}!");
        }

        public void PrintTable(int number)
        {
            Console.WriteLine($"Таблица умножения для {number}:");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{number} x {i} = {number * i}");
        }

        // ===== 3 метода с возвращаемыми значениями =====
        public int Add(int a, int b) => a + b;

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
                return 0;
            }
            return (double)a / b;
        }

        public string CheckEven(int number) => number % 2 == 0 ? "Чётное" : "Нечётное";
    }
}

