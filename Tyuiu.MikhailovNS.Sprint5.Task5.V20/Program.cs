using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.MikhailovNS.Sprint5.Task5.V20.Lib;

namespace Tyuiu.MikhailovNS.Sprint5.Task5.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Обработка файлов                                                   *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #20                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask5V20.txt (файл взять из архива  *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:/DataSprint5/ и       *");
            Console.WriteLine("* скопировать в неё файл) в котором есть вещественное значение. Найти      *");
            Console.WriteLine("* среднее значение всех целых чисел в файле, которые находятся в           *");
            Console.WriteLine("* промежутке от -10 до 10. Полученный результат вывести на консоль.        *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = @"C:\Sprint5\InPutDataFileTask5V20.txt";

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Данные хранятся в файле" + path);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Среднее арифметическое всех чисел в промежутке (-10;10) равно: "+ res);
            Console.ReadKey();
        }
    }
}
