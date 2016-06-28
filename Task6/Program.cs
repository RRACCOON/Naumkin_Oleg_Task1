using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача № 6{0}Данная задача имитиурет управления стилями текста"
                , Environment.NewLine);

            bool bold = false;
            bool italic = false;
            bool underline = false;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Введите:{0}1 - Bold{1}2 - Italic{2}3 - Underline{3}0 - Чтобы выйти ", Environment.NewLine, Environment.NewLine, Environment.NewLine, Environment.NewLine);
                string c = Console.ReadLine();
                switch (c)
                {

                    case "1":
                            bold = !bold;
                        break;
                    case "2":
                            italic = !italic;
                        break;
                    case "3":
                        underline = !underline;
                        break;
                    case "0":
                        exit = !exit;
                        break;
                    default:
                        Console.WriteLine("!!!Некорректная команда!!!");
                        break;
                }
                string p= "";
                if (bold) p = p + "Bold ";
                if (italic) p = p + "Italic ";
                if (underline) p = p + "Underline ";

                Console.WriteLine("~~~~~~~~~~~~~{0}Параметры текста: {1}{2}~~~~~~~~~~~~~", Environment.NewLine, p, Environment.NewLine);
            }            
        }
    }
}
