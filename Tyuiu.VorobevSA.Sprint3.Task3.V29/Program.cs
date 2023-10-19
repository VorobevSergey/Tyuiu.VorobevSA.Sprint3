using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint3.Task3.V29.Lib;

namespace Tyuiu.VorobevSA.Sprint3.Task3.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:Оператор цикла foreach                                              *");
            Console.WriteLine("* Задание #3.3                                                            *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Используя цикл foreach удалить из строки все буквы h в строке            *");
            Console.WriteLine("*: chgr vhhtg hnht                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "chgr vhhtg hnht";
            char item = 'h';

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Искомая буква: " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("получилась строка=" + service1.DeleteCharInString(value, item));
            Console.ReadKey();
        }
    }
}
