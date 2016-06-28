using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача № 5{0}Данная задача выдает сумму чисел меньше 1000, кратных 3 и 5"
                , Environment.NewLine);
            int n = 1000;
            int sum = 0;

            ////если краткость - сестра таланта, то код следующий:
            //for (int i = 0; i < n; i++)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //        sum = sum + i;
            //}

            //Но в программировании дела по-другому обстоят :)
            int sum3;
            int sum5;
            int sum15;
            int an;
            int N;
            int i = 1;
            while ((n - i) % 3 != 0)
            {
                i++;
            }
            an = (n - i);
            N = (n - i) / 3;
            sum3 = (2 * 3 + (N - 1) * 3) * N / 2;
            i = 1;
            while ((n - i) % 5 != 0)
            {
                i++;
            }
            an = (n - i);
            N = (n - i) / 5;
            sum5 = (2 * 5 + (N - 1) * 5) * N / 2;
            i = 1;
            while ((n - i) % 15 != 0)
            {
                i++;
            }

            an = (n - i);
            N = (n - i) / 15;
            sum15 = (2 * 15 + (N - 1) * 15) * N / 2;

            sum = sum3 + sum5 - sum15;

            Console.WriteLine("Cумма = {0}", sum);
            Console.WriteLine("{0}Нажмите ENTER для завершения работы", Environment.NewLine);
            Console.ReadLine();
        }
    }
}
