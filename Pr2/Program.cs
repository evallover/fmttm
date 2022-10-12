namespace Pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteChooseOperation();
            }
        }
        static void WriteChooseOperation()
        {
            string operation;
            operation = null;
            Console.WriteLine("Выберите программу, которую вы хотите запустить:");
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Закрыть программу");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    GetRandom();
                    break;
                case "2":
                    MultiplicationTable();
                    break;
                case "3":
                    Delitel();
                    break;
                case "4":

                    Environment.Exit(0);
                    break;
            }

        }
        static void GetRandom()
        {
            int operation;
            int value;
            Console.WriteLine("Угадай число от 0 до 100!");

            Random rnd = new Random();

            value = rnd.Next(0, 100);

            do
            {
                operation = int.Parse(Console.ReadLine());
                if (operation < value)
                {
                    Console.WriteLine("Нужно больше");
                }
                else if (operation > value)
                {
                    Console.WriteLine("Нужно меньше");
                }
            }
            while (operation != value);
            Console.WriteLine("Угадал!");
        }

        static void MultiplicationTable()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write($"{i * j}\t");
                Console.WriteLine();
            }
        }

        static void Delitel()
        {
            Console.WriteLine("Выберите число :");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    Console.WriteLine("{0} делится на {1} без остатка", number, i);
            }
        }
    }
}