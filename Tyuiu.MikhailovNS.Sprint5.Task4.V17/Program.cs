using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.MikhailovNS.Sprint5.Task4.V17.Lib;

namespace Tyuiu.MikhailovNS.Sprint5.Task4.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Обработка файлов                                                   *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #17                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask4V0.txt (файл взять из архива   *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:/DataSprint5/ и       *");
            Console.WriteLine("* скопировать в неё файл) в котором есть вещественное значение. Прочитать  *");
            Console.WriteLine("* значение из файла и подставить вместо Х в формуле y=sin(2/3x)+x^2        *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить до трёх     *");
            Console.WriteLine("* знаков после запятой) и вернуть полученный результат на консоль.         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = @"C:\Sprint5\InPutDataFileTask4V17.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}