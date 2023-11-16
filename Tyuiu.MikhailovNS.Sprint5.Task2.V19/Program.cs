using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint5.Task2.V19.Lib;

namespace Tyuiu.MikhailovNS.Sprint5.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Обработка файлов                                                   *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #19                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный         *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.        *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int[,] mat = new int[3, 3] { { 9, 2, 5},
                                            { 8, 8, 2},
                                            { 7, 4, 8} };

            int rows = mat.GetUpperBound(0) + 1;
            int columns = mat.GetUpperBound(1) + 1;

            Console.WriteLine("\nМассив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mat[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            string res = ds.SaveToFileTextData(mat);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.WriteLine("\nМассив, с 0 вместо нечетных элементов:");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if (mat[i, j] % 2 != 0)
                    {
                        mat[i, j] = 0;
                    }
                    Console.Write($"{mat[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
