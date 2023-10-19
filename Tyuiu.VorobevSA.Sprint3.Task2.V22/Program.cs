using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint3.Task2.V22.Lib;

namespace Tyuiu.VorobevSA.Sprint3.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            double x = 5;
            int q = 1;
            int w = 7;
            Console.Title = "Спринт #3 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:Оператор цикла do...whil                                           *");
            Console.WriteLine("* Задание #3.2                                                            *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу используя цикл do...while, которая вычисляет          *");
            Console.WriteLine("*произведение ряда по формуле                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("x="+x);
            Console.WriteLine("Начало шага=" + q);
            Console.WriteLine("Конец шага=" + w);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда=" + service1.GetSumSeries(x, q, w));
            Console.ReadKey();
        }
    }
}
