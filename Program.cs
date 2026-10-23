using System;

namespace лаб4стр9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string poems = " тучки небесные, вечные странники...";
            char[] div = { ' ', ',', '.' };
            string[] parts = poems.Split(div,
                StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Результат разбиения строки на части:");
            for (int i = 0; i < parts.Length; i++)
                Console.WriteLine(parts[i]);

            // Размещаем слова в обратном порядке перед сборкой.
            Array.Reverse(parts);
            string whole = String.Join(" | ", parts);
            Console.WriteLine("Результат сборки:");
            Console.WriteLine(whole);
        }
    }
}
