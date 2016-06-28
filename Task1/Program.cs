using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задача № 1{0}Данная задача вычисляет площадь ПРЯМОУГОЛЬНИКА по заданным сторонам.{1}Введите стороны А: ", Environment.NewLine, Environment.NewLine);
            int a = Convert.ToInt32(Console.ReadLine());
            int b;
            if (a<=0)
            {
                Console.WriteLine("Ошибка ввода!");
            }
            else
            {
                Console.Write(@"Введите сторону B: ");
                b = Convert.ToInt32(Console.ReadLine());

                if (b <= 0)
                    Console.WriteLine("Ошибка ввода!");
                else
                {
                    Console.WriteLine("Площадь прямоугольника = {0}", a * b);
                }
            }

            Console.WriteLine("{0}Нажмите ENTER для завершения работы", Environment.NewLine);
            Console.ReadLine();
        }
    }
}
