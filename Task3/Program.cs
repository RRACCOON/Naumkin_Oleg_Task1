using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задача № 3{0}Данная задача создает ОБЫЧНЫЙ ТРЕУГОЛЬНИК из символов.{1}Введите количество строк N: ", Environment.NewLine, Environment.NewLine);
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Ошибка ввода!");
            }
            else
            {
                for (int i = 1; i <=n; i++)
                {
                    for (int j = 0; j < n - i; j++)
                        Console.Write(" ");

                    for (int j = 0; j < 2 * i - 1; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("{0}Нажмите ENTER для завершения работы", Environment.NewLine);
            Console.ReadLine();
        }
    }
}
