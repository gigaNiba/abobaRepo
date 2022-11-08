using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Сгенерированный массив: ");

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-2000, 2000); // Заполняем массив случайными числами
                Console.Write(arr[i] + "  ");
            }

            // Ищем нужные числа
            Console.WriteLine("\n\nНовый массив: ");
            for (int i = 0; i < n; i++)
            {
                string s = Convert.ToString(arr[i]);
                int l = s.Length;
                string sub = s.Substring(l - 2, 2); // Вычленяем последние 2 символа и сравниваем
                if (sub == "49")
                {
                    Console.WriteLine(arr[i]);
                }

            }

            Console.ReadLine();

        }
    }
}
