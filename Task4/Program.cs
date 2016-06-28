using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задача № 4{0}Данная задача создает ЁЛОЧКУ из символов.{1}Ёлочка состоит из пики и треугольников.{2}Введите количество треугольников N: "
                , Environment.NewLine, Environment.NewLine, Environment.NewLine);

            int n = Convert.ToInt32(Console.ReadLine());
            n++; //т.к. пика ёлки не считается треугольником
            if (n <= 0)
            {
                Console.WriteLine("Ошибка ввода!");
            }
            else
            {                
                for (int g = 1; g <= n; g++)
                    for (int i = 1; i <= g; i++)
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
