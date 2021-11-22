using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем текстовый файл в выбранной папке

            string path = @"C:/Task8/Task8.2.txt";
            //if (!File.Exists(path))
            //{
            //   File.Create(path);
            //}

            // 2. Записываем в текстовый файл 10 случайных чисел

            using (StreamWriter sw = new StreamWriter(path))
            {
                const int N = 10;
                int[] number = new int[N];
                Random random = new Random();

                for (int i = 0; i < N; i++)
                {
                    number[i] = random.Next(0, 50);
                    sw.WriteLine("{0} ", number[i]);
                }
            }

            // 3. Считываем содержимое файла

            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine("Список чисел из файла");
                Console.WriteLine();
                Console.WriteLine(sr.ReadToEnd());
            }

            // 4. Преобразуем строку в число, считаем сумму
            string[] Numbers = System.IO.File.ReadAllLines(path);
            int sum = 0;
            foreach (string Num in Numbers)
            {
                if (Int32.TryParse(Num, out int number))
                {
                    sum = sum + number;
                }
            }

            Console.WriteLine("Сумма чисел = " + sum);

            Console.ReadKey();
        }
    }
}
